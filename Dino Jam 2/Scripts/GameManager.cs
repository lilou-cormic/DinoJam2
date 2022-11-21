using Godot;

public class GameManager : Node2D
{
    private static GameManager _instance;

    private float _speedMultiplier = 2;

    public static float SpeedMultiplier => _instance._speedMultiplier;

    public GameManager()
    {
        _instance = this;
    }

    public override void _Ready()
    {
        ScoreManager.ResetScore();
    }

    public static void SpeedUp()
    {
        _instance._speedMultiplier += 0.25f;
    }

    public static void GameOver()
    {
        _instance.GetTree().ChangeScene(@"res://Scenes/GameOver.tscn");
    }
}