using Godot;
using System;
using System.Numerics;
public partial class Ball : Area2D
{
    private const int DefaultSpeed = 150;

    public Godot.Vector2 direction = Godot.Vector2.Left;
    

    private Godot.Vector2 _initialPos;
    private double _speed = DefaultSpeed;

    public override void _Ready()
    {
        _initialPos = Position;
        //makes ball go in random direction at the beginning of the game
        if (Math.Round(new Random().NextDouble()) > 0) {
            direction = Godot.Vector2.Right;
        } else {
            direction = Godot.Vector2.Left;
        }   
    }

    public override void _Process(double delta)
    {
        _speed += delta * 8;
        Position += (float)(_speed * delta) * direction;
    }

    public void Reset(String directionName)
    {
        //sends the ball towards the player who just scored
        if (directionName == "Left") {
            direction = Godot.Vector2.Left;
        } else {
            direction = Godot.Vector2.Right;
        }
        
        Position = _initialPos;
        _speed = DefaultSpeed;
    }
}
