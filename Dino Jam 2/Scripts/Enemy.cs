using Godot;
using System;

public class Enemy : WrapHorizontal
{
    public override void _PhysicsProcess(float delta)
    {
        base._PhysicsProcess(delta);

        if (GlobalPosition.x < 250)
        {
            if (GlobalPosition.y < 440)
            {
                GlobalPosition += Vector2.Down * 300 * delta;
            }
        }
        else
        {
            if (GlobalPosition.y > 260 && GlobalPosition.x < 560)
            {
                GlobalPosition += Vector2.Up * 400 * delta;
            }
        }
    }
}
