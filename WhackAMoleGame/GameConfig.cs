namespace WhackAMoleGame;

public class GameConfig
{
    public string LevelName = "普通";
    public int GameTime = 60;
    public int ShowInterval = 900;
    public int StayTime = 1300;
    public int MoleCount = 2;

    public static GameConfig Create(string levelName)
    {
        GameConfig config = new GameConfig();
        config.LevelName = levelName;

        if (levelName == "简单")
        {
            config.ShowInterval = 1100;
            config.StayTime = 1600;
            config.MoleCount = 1;
        }
        else if (levelName == "困难")
        {
            config.ShowInterval = 650;
            config.StayTime = 900;
            config.MoleCount = 3;
        }
        else
        {
            config.ShowInterval = 900;
            config.StayTime = 1300;
            config.MoleCount = 2;
        }

        return config;
    }
}
