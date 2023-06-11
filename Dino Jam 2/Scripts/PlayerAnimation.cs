using Godot;

public class PlayerAnimation : AnimatedSprite
{
    private float _normalSpeed;

    public override void _Ready()
    {
        _normalSpeed = SpeedScale;
    }

    public override void _PhysicsProcess(float delta)
    {
        float speed = _normalSpeed * GameManager.SpeedMultiplier * 0.5f;

        if (Input.IsActionPressed("fly") || Input.IsActionPressed("right") || Input.IsActionPressed("down"))
        {
            SpeedScale = speed * 3;
        }
        else if (Input.IsActionPressed("left"))
        {
            SpeedScale = speed * 0.75f;
        }
        else
        {
            SpeedScale = speed;
        }
    }
}
