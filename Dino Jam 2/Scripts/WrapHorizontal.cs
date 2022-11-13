using Godot;

public class WrapHorizontal : Node2D
{
    [Export] public float Speed = 100;
    [Export] public float Width = 70;
    [Export] public float Multiplier = 18;

    public override void _PhysicsProcess(float delta)
    {
        GlobalPosition += Vector2.Left * delta * Speed * GameManager.SpeedMultiplier;

        if (GlobalPosition.x < -Width)
        {
            GlobalPosition += Vector2.Right * Width * Multiplier;
        }
    }
}