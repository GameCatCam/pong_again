using Godot;

public partial class  VictoryScene : Node {
    private Label winnerLabel;

    public override void _Ready(){
        GD.Print("Game over!");
        //selects the winner label node in the scene tree
        winnerLabel = GetNode<Label>("Winner Label");
        //pulls the winner data from the global data
        string winnerName = GlobalData.GetInstance().WinnerName;
        //sets the winner label text to the winner
        winnerLabel.Text = $"{winnerName} wins!";
    }
}

