using System.ComponentModel;

namespace BattlefieldCSharp.Controls;

/// <summary>
/// Kolumna drużyny: nagłówek w kolorze drużyny + przewijana lista kart UnitCard.
/// Używana dwa razy – po lewej (twoja drużyna) i po prawej (przeciwnicy).
/// </summary>
public partial class TeamPanel : UserControl
{
    private Color _accentColor = Color.FromArgb(54, 120, 190);

    public TeamPanel()
    {
        InitializeComponent();
    }

    [Category("Team")]
    [DefaultValue("TEAM")]
    public string Title
    {
        get => lblTitle.Text;
        set => lblTitle.Text = value;
    }

    [Category("Team")]
    [DefaultValue(typeof(Color), "54, 120, 190")]
    public Color AccentColor
    {
        get => _accentColor;
        set
        {
            _accentColor = value;
            lblTitle.ForeColor = value;
            foreach (var card in Units)
                card.AccentColor = value;
        }
    }

    [Browsable(false)]
    public IReadOnlyList<UnitCard> Units => flpUnits.Controls.OfType<UnitCard>().ToList();

    public UnitCard AddUnit(string name, string role, int health, int maxHealth)
    {
        var card = new UnitCard(name, role, health, maxHealth, _accentColor);
        AddUnit(card);
        return card;
    }

    public void AddUnit(UnitCard card)
    {
        card.AccentColor = _accentColor;
        flpUnits.Controls.Add(card);
        card.Width = CardWidth; // dopiero po dodaniu – po ewentualnym skalowaniu DPI
    }

    public void ClearUnits()
    {
        foreach (var card in Units)
        {
            flpUnits.Controls.Remove(card);
            card.Dispose();
        }
    }

    private int CardWidth =>
        Math.Min(160, flpUnits.ClientSize.Width - flpUnits.Padding.Horizontal - SystemInformation.VerticalScrollBarWidth - 2);

    // Karty rozciągają się na szerokość kolumny.
    private void flpUnits_Resize(object? sender, EventArgs e)
    {
        flpUnits.SuspendLayout();
        foreach (var card in Units)
            card.Width = CardWidth;
        flpUnits.ResumeLayout();
    }
}
