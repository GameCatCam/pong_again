using Godot;
using System;

public partial class Paddle : Area2D
{
    private const int MoveSpeed = 200;

    // All three of these change for each paddle.
    private int _ballDir;
    private string _up;
    private string _down;
    private string _slow;

    public override void _Ready()
    {
        string name = Name.ToString().ToLower();
        _up = name + "_move_up";
        _down = name + "_move_down";
        _ballDir = name == "left" ? 1 : -1;
        _slow = name + "_slow_speed";
    }

    public override void _Process(double delta)
    {
        // Move up and down based on input.
        float input = Input.GetActionStrength(_down) - Input.GetActionStrength(_up);
        if (Input.GetActionStrength(_slow) > 0){
            Vector2 position = Position; // Required so that we can modify position.y.
            position += new Vector2(0, input * (MoveSpeed/2) * (float)delta);
            position = new(position.X, Mathf.Clamp(position.Y, 16, GetViewportRect().Size.Y - 16));
            Position = position;
        } else {
            Vector2 position = Position; // Required so that we can modify position.y.
            position += new Vector2(0, input * MoveSpeed * (float)delta);
            position = new(position.X, Mathf.Clamp(position.Y, 16, GetViewportRect().Size.Y - 16));
            Position = position;
        }
    }

    public void OnAreaEntered(Area2D area)
    {
        if (area is Ball ball)
        {
            // Assign new direction
            ball.direction = new Vector2(_ballDir, ((float)new Random().NextDouble()) * 2 - 1).Normalized();
        }
    }
}
