using Godot;
using System;

public class ScoreDisplay : Label
{
    [Export] bool IsHighScore = false;

    public ScoreDisplay()
    {
        ScoreManager.ScoreChanged += ScoreManager_ScoreChanged;
    }

    public override void _Ready()
    {
        SetText();
    }

    public override void _ExitTree()
    {
        ScoreManager.ScoreChanged -= ScoreManager_ScoreChanged;
    }

    private void ScoreManager_ScoreChanged()
    {
        SetText();
    }

    private void SetText()
    {
        Text = (IsHighScore ? ScoreManager.HighScore : ScoreManager.Score).ToString("000");
    }
}
