using Godot;

public partial class  GameScene : Node {


    public override void _Ready()
    {
        GD.Print("Starting the game!");
    }

    public void EndGame(string winner) {
        //saves info to a global variable for access
        GlobalData.GetInstance().WinnerName = winner;
        //changes the scene to the victory scene
        GetTree().ChangeSceneToFile("Winner.tscn");
    }
}