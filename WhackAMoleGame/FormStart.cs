namespace WhackAMoleGame;

public partial class FormStart : Form
{
    public FormStart()
    {
        InitializeComponent();
    }

    private void buttonStart_Click(object? sender, EventArgs e)
    {
        string playerName = textBoxName.Text.Trim();

        if (playerName == "")
        {
            MessageBox.Show("请输入玩家姓名");
            return;
        }

        string levelName = comboBoxLevel.Text;
        GameConfig config = GameConfig.Create(levelName);
        bool playAgain = true;

        this.Visible = false;

        while (playAgain)
        {
            FormGame frmGame = new FormGame(playerName, config);
            frmGame.ShowDialog();
            playAgain = frmGame.PlayAgain;
        }

        this.Visible = true;
    }

    private void buttonExit_Click(object? sender, EventArgs e)
    {
        this.Close();
    }

}
