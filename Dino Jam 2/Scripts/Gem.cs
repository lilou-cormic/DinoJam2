using Godot;

public class Gem : Area2D
{
    public const float Speed = 75;

    private bool _clockwise = true;

    public void OnBodyEntered(PhysicsBody2D body)
    {
        ScoreManager.Add(1);

        GemSoundPlayer.PlaySound();

        QueueFree();
    }

    public override void _PhysicsProcess(float delta)
    {
        if (_clockwise)
        {
            RotationDegrees += delta * Speed;

            if (RotationDegrees > 15)
            {
                _clockwise = false;
            }
        }
        else
        {
            RotationDegrees -= delta * Speed;

            if (RotationDegrees < -15)
            {
                _clockwise = true;
            }
        }
    }
}
