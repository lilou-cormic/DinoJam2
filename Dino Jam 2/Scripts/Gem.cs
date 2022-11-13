using Godot;

public class Gem : Area2D
{
    public void OnBodyEntered(PhysicsBody2D body)
    {
        ScoreManager.Add(1);
        QueueFree();
    }
}
