namespace WhackAMoleGame;

public partial class FormEnd : Form
{
    public bool PlayAgain = false;

    public FormEnd()
    {
        InitializeComponent();
    }

    public FormEnd(string playerName, GameConfig config, GameStats stats)
    {
        InitializeComponent();
        labelInfo.Text =
            "玩家：" + playerName + "\r\n" +
            "难度：" + config.LevelName + "\r\n" +
            "最终得分：" + stats.Score + "\r\n" +
            "命中次数：" + stats.HitCount + "    漏掉次数：" + stats.MissCount + "\r\n" +
            "命中率：" + stats.GetHitRate().ToString("0.0") + "%\r\n" +
            "最高连击：" + stats.MaxCombo + "\r\n" +
            "评价等级：" + stats.GetLevelText();
    }


    private void buttonAgain_Click(object? sender, EventArgs e)
    {
        PlayAgain = true;
        this.Close();
    }

    private void buttonBack_Click(object? sender, EventArgs e)
    {
        PlayAgain = false;
        this.Close();
    }
}
