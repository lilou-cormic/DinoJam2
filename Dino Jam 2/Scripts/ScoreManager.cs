using System;

public static class ScoreManager
{
    public static int Score { get; private set; }
    public static int HighScore;

    public static event Action ScoreChanged;

    public static void ResetScore()
    {
        Score = 0;

        OnScoreChanged();
    }

    public static void Add(int value)
    {
        Score += value;

        if (Score >= HighScore)
            HighScore = Score;

        OnScoreChanged();
    }

    private static void OnScoreChanged()
    {
        ScoreChanged?.Invoke();
    }
}
