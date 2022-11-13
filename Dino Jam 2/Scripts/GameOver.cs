using Godot;
using System;

public class GameOver : Control
{
    public void OnRetryButtonPressed()
    {
        GetTree().ChangeScene(@"res://Scenes/Main.tscn");
    }

    public void OnQuitButtonPressed()
    {
        GetTree().Quit();
    }
}
