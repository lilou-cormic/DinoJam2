using Godot;

public class WrapHorizontal : MoveHorizontal
{
    protected override void ManageReachedLimit()
    {
        GlobalPosition += Vector2.Right * Width * Multiplier;
    }
}