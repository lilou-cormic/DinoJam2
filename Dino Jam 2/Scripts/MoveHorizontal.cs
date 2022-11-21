using Godot;

public abstract class MoveHorizontal : Node2D
{
    [Export] public float Speed = 100;
    [Export] public float Width = 70;
    [Export] public float Multiplier = 9 * 3;

    public override void _PhysicsProcess(float delta)
    {
        GlobalPosition += Vector2.Left * delta * Speed * GameManager.SpeedMultiplier;

        if (GlobalPosition.x < -Width)
        {
            ManageReachedLimit();
        }
    }

    protected abstract void ManageReachedLimit();
}
