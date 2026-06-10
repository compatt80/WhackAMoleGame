namespace WhackAMoleGame;

public class GameStats
{
    public int Score = 0;
    public int HitCount = 0;
    public int MissCount = 0;
    public int ClickCount = 0;
    public int MaxCombo = 0;

    public double GetHitRate()
    {
        if (ClickCount == 0)
        {
            return 0;
        }

        return HitCount * 100.0 / ClickCount;
    }

    public string GetLevelText()
    {
        double hitRate = GetHitRate();

        if (Score >= 1500 && hitRate >= 70 && MissCount <= 50 && MaxCombo >= 15)
        {
            return "优秀";
        }
        else if (Score >= 800 && hitRate >= 50 && MissCount <= 70 && MaxCombo >= 10)
        {
            return "良好";
        }
        else if (Score >= 500 && hitRate >= 40 && MissCount <=  90 && MaxCombo >= 5)
        {
            return "合格";
        }
        else
        {
            return "继续努力";
        }
    }
}
