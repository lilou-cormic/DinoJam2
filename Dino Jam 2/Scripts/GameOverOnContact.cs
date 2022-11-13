using Godot;

public class GameOverOnContact : Area2D
{
    public void OnBodyEntered(PhysicsBody2D body)
    {
        GameManager.GameOver();
    }
}
