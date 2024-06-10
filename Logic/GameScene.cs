using Godot;

public partial class  GameScene : Node {
    public override void _Ready()
    {
        GD.Print("Starting the game!");
    }

    public void EndGame() {
        GetTree().ChangeSceneToFile("Winner.tscn");
    }
}