using System.ComponentModel;

namespace BattlefieldCSharp.Controls;

/// <summary>
/// Karta jednostki: nazwa, rola, liczba HP i pasek HP.
/// HP jest pilnowane przez właściwości (0..MaxHealth) – z zewnątrz nie da się ustawić złej wartości.
/// </summary>
public partial class UnitCard : UserControl
{
    private int _health = 100;
    private int _maxHealth = 100;
    private Color _accentColor = Color.FromArgb(54, 120, 190);

    public UnitCard()
    {
        InitializeComponent();
        UpdateHealthView();
    }

    public UnitCard(string unitName, string role, int health, int maxHealth, Color accentColor) : this()
    {
        UnitName = unitName;
        Role = role;
        MaxHealth = maxHealth;
        Health = health;
        AccentColor = accentColor;
    }

    /// <summary>Wywoływane po każdej zmianie HP.</summary>
    public event EventHandler? HealthChanged;

    [Category("Unit")]
    [DefaultValue("Unit")]
    public string UnitName
    {
        get => lblName.Text;
        set => lblName.Text = value;
    }

    [Category("Unit")]
    [DefaultValue("Role")]
    public string Role
    {
        get => lblRole.Text;
        set => lblRole.Text = value;
    }

    [Category("Unit")]
    [DefaultValue(100)]
    public int MaxHealth
    {
        get => _maxHealth;
        set
        {
            _maxHealth = Math.Max(1, value);
            _health = Math.Min(_health, _maxHealth);
            UpdateHealthView();
        }
    }

    [Category("Unit")]
    [DefaultValue(100)]
    public int Health
    {
        get => _health;
        set
        {
            int clamped = Math.Clamp(value, 0, _maxHealth);
            if (clamped == _health) return;
            _health = clamped;
            UpdateHealthView();
            HealthChanged?.Invoke(this, EventArgs.Empty);
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

    [Browsable(false)]
    public bool IsAlive => _health > 0;

    public void TakeDamage(int amount) => Health -= Math.Max(0, amount);

    public void Heal(int amount) => Health += Math.Max(0, amount);

    private void UpdateHealthView()
    {
        lblHealth.Text = $"{_health} / {_maxHealth} HP";

        lblName.ForeColor = IsAlive ? Color.White : Color.FromArgb(110, 115, 125);
        pnlHpTrack.Invalidate(); // przerysuj pasek HP
    }

    // Pasek HP rysowany ręcznie: wypełnienie proporcjonalne do HP, kolor zależny od poziomu.
    private void pnlHpTrack_Paint(object? sender, PaintEventArgs e)
    {
        double ratio = (double)_health / _maxHealth;
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
