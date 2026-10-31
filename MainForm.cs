namespace BattlefieldCSharp;

/// <summary>
/// Główne okno. Układ (lewo / środek / prawo) jest w MainForm.Designer.cs,
/// tutaj tylko dane startowe drużyn.
/// </summary>
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        LoadSampleUnits();
    }

    private void LoadSampleUnits()
    {
        teamPlayer.AddUnit("Knight", "Front line", 82, 100);
        teamPlayer.AddUnit("Archer", "Ranged", 56, 80);
        teamPlayer.AddUnit("Healer", "Support", 40, 60);

        teamEnemy.AddUnit("Orc", "Front line", 70, 100);
        teamEnemy.AddUnit("Warlock", "Magic", 32, 70);
        teamEnemy.AddUnit("Goblin", "Skirmisher", 25, 50);
    }
}
