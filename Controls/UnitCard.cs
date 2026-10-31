using System.ComponentModel;
using BattlefieldCSharp.Model;

namespace BattlefieldCSharp.Controls;

/// <summary>
/// Karta jednostki: tylko wyświetla stan obiektu Unit (nazwa, rola, HP, pasek HP)
/// i odświeża się sama, gdy model zgłosi zmianę HP. Logika HP siedzi w Unit.
/// </summary>
public partial class UnitCard : UserControl
{
    private Unit? _unit;
    private Color _accentColor = Color.FromArgb(54, 120, 190);

    public UnitCard()
    {
        InitializeComponent();
        Disposed += (_, _) => Unit = null; // odpinamy event, żeby model nie trzymał martwej kontrolki
    }

    public UnitCard(Unit unit, Color accentColor) : this()
    {
        Unit = unit;
        AccentColor = accentColor;
    }

    /// <summary>Wyświetlana jednostka. Zmiana podpina/odpina zdarzenie HealthChanged.</summary>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Unit? Unit
    {
        get => _unit;
        set
        {
            if (_unit == value) return;
            if (_unit != null) _unit.HealthChanged -= Unit_HealthChanged;
            _unit = value;
            if (_unit != null) _unit.HealthChanged += Unit_HealthChanged;
            RefreshView();
        }
    }

    [Category("Unit")]
    [DefaultValue(typeof(Color), "54, 120, 190")]
    public Color AccentColor
    {
        get => _accentColor;
        set
        {
            _accentColor = value;
            pnlAccent.BackColor = value;
        }
    }

    private void Unit_HealthChanged(object? sender, EventArgs e) => RefreshView();

    private void RefreshView()
    {
        if (_unit == null) return; // bez modelu (np. w designerze) zostają domyślne teksty

        lblName.Text = _unit.Name;
        lblRole.Text = _unit.Role;
        lblHealth.Text = $"{_unit.Health} / {_unit.MaxHealth} HP";

        lblName.ForeColor = _unit.IsAlive ? Color.White : Color.FromArgb(110, 115, 125);
        pnlHpTrack.Invalidate(); // przerysuj pasek HP
    }

    // Pasek HP rysowany ręcznie: wypełnienie proporcjonalne do HP, kolor zależny od poziomu.
    private void pnlHpTrack_Paint(object? sender, PaintEventArgs e)
    {
        if (_unit == null) return;

        double ratio = (double)_unit.Health / _unit.MaxHealth;
        int fillWidth = (int)Math.Round(pnlHpTrack.ClientSize.Width * ratio);
        if (fillWidth <= 0) return;

        Color fillColor = ratio > 0.5 ? Color.FromArgb(76, 175, 80)
                        : ratio > 0.25 ? Color.FromArgb(230, 162, 60)
                        : Color.FromArgb(214, 69, 65);

        using var brush = new SolidBrush(fillColor);
        e.Graphics.FillRectangle(brush, 0, 0, fillWidth, pnlHpTrack.ClientSize.Height);
    }

    private void pnlHpTrack_Resize(object? sender, EventArgs e) => pnlHpTrack.Invalidate();
}
