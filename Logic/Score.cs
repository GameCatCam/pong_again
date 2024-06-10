using Godot;

public partial class Score : Control
{
    // References to the score labels
    private Label scoreLeftLabel;
    private Label scoreRightLabel;

    // Scores for left and right players
    private int scoreLeft = 0;
    private int scoreRight = 0;

    // Called when the node enters the scene tree for the first time
    public override void _Ready()
    {
        // Get references to the score labels
        scoreLeftLabel = GetNode<Label>("Score_Left");
        scoreRightLabel = GetNode<Label>("Score_Right");

        // Update the initial score display
        UpdateScoreLabels();
    }

    // Method to update the score labels with the current scores
    private void UpdateScoreLabels()
    {
        // Update the text of the score labels with the current scores
        scoreLeftLabel.Text = scoreLeft.ToString();
        scoreRightLabel.Text = scoreRight.ToString();
    }

    // Method to increase the score for the left player
    public void IncreaseScoreLeft()
    {
        // Increase the score for the left player
        scoreLeft++;

        // Update the score labels
        UpdateScoreLabels();
    }

    // Method to increase the score for the right player
    public void IncreaseScoreRight()
    {
        // Increase the score for the right player
        scoreRight++;

        // Update the score labels
        UpdateScoreLabels();
    }
}