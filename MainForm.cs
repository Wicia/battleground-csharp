using System.Data;
using System.Xml.Linq;
using BattlefieldCSharp.Model;

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

    private async void LoadSampleUnits()
    {
        var player1 = new Unit("Knight", "Front line", 82);
        var player2 = new Unit("Orc", "Front line", 70);





        teamPlayer.AddUnit(player1);
        teamEnemy.AddUnit(player2);
        await Task.Delay(2000);

        player2.TakeDamage(30);

    }
}
