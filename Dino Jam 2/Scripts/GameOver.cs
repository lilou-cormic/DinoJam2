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

    public override void _Process(float delta)
    {
        if (Input.IsActionJustPressed("ui_accept"))
            OnRetryButtonPressed();

        if (Input.IsActionJustPressed("ui_cancel"))
            OnQuitButtonPressed();
    }
}
