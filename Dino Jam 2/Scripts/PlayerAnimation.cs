using Godot;
using System;

public class PlayerAnimation : AnimatedSprite
{
    private float _normalSpeed;

    public override void _Ready()
    {
        _normalSpeed = SpeedScale;
    }

    public override void _PhysicsProcess(float delta)
    {
        if (Input.IsActionPressed("fly"))
        {
            SpeedScale = _normalSpeed * 3;
        }
        else
        {
            SpeedScale = _normalSpeed;
        }
    }
}
