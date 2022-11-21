using Godot;

public class Enemy : Node2D
{
    private bool goingDown = false;

    public override void _Ready()
    {
        if (GlobalRotation == 0)
            GlobalPosition = new Vector2(GlobalPosition.x, 440);
        else
            QueueFree();
    }

    public override void _PhysicsProcess(float delta)
    {
        if (GlobalPosition.x > -70)
        {
            if (GlobalPosition.x < 250)
            {
                if (GlobalPosition.y < 440)
                {
                    goingDown = true;

                    GlobalPosition += Vector2.Down * 300 * delta * GameManager.SpeedMultiplier;
                }
            }
            else if (!goingDown)
            {
                if (GlobalPosition.y > 260 && GlobalPosition.x < 560)
                {
                    GlobalPosition += Vector2.Up * 400 * delta * GameManager.SpeedMultiplier;

                    if (GlobalPosition.y < 260)
                        GlobalPosition = new Vector2(GlobalPosition.x, 260);
                }
            }
        }
    }
}
