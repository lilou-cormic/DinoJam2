using Godot;
using System;

public class WrapHorizontal : Node2D
{    
    [Export] public float Width = 70;

    public override void _PhysicsProcess(float delta)
    {
        GlobalPosition += Vector2.Left * delta * 100;

        if (GlobalPosition.x < -Width)
        {
            GlobalPosition += Vector2.Right * Width * 11;
        }
    }
}
