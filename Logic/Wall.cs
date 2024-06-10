using Godot;

public partial class Wall : Area2D
{
    //exports the NodePath to be assignable in Godot, you set it to the Score node
    [Export]
    public NodePath scoreNodePath;
    private Score score;
    public override void _Ready()
    {
        score = GetNode<Score>(scoreNodePath);
    }
    public void OnWallAreaEntered(Area2D area)
    {
        if (area is Ball ball)
        {
            // Ball went off the side of the screen, reset it.
            ball.Reset();

            // Determine which side the ball hit and update the score
            if (Name == "LeftWall")
            {
                score.IncreaseScoreRight();
            }
            else if (Name == "RightWall")
            {
                score.IncreaseScoreLeft();
            }

        }
    }
}
