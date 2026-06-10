namespace WhackAMoleGame;

public partial class FormGame : Form
{
    PictureBox[] holes = new PictureBox[9];
    Mole[] moles = new Mole[9];
    Random random = new Random();
    GameStats stats = new GameStats();
    GameConfig config;
    string playerName;

    Image holeImage = null!;
    Image moleImage = null!;
    Image goldMoleImage = null!;
    int leftTime;
    int showTimeCount = 0;
    int comboCount = 0; 
    bool isPause = false;

    public bool PlayAgain = false;

    public FormGame()
    {
        playerName = "同学";
        config = GameConfig.Create("普通");
        leftTime = config.GameTime * 10;

        InitializeComponent();
        LoadGameImages();
    }

    public FormGame(string name, GameConfig gameConfig)
    {
        playerName = name;
        config = gameConfig;
        leftTime = config.GameTime * 10;

        InitializeComponent();
        LoadGameImages();
        InitGame();
    }

    private void LoadGameImages()
    {
        holeImage = Image.FromFile(@"D:\C#ppt\WhackAMoleGame\Images\hole.png");
        moleImage = Image.FromFile(@"D:\C#ppt\WhackAMoleGame\Images\mole.png");
        goldMoleImage = Image.FromFile(@"D:\C#ppt\WhackAMoleGame\Images\gold_mole.png");
    }

    private void InitGame()
    {
        labelPlayer.Text = "玩家：" + playerName;

        int holeWidth = 120;
        int holeHeight = 100;
        int spaceX = 175; 
        int spaceY = 140;
        int gridWidth = holeWidth + 2 * spaceX; 
        int gridHeight = holeHeight + 2 * spaceY;
        int startX = (panelGame.Width - gridWidth) / 2;
        int startY = (panelGame.Height - gridHeight) / 2;

        for (int i = 0; i < holes.Length; i++)
        {
            holes[i] = new PictureBox();
            holes[i].Size = new Size(holeWidth, holeHeight);
            holes[i].SizeMode = PictureBoxSizeMode.StretchImage;
            holes[i].Image = holeImage;
            holes[i].BackColor = Color.Transparent;
            holes[i].Location = new Point(startX + i % 3 * spaceX, startY + i / 3 * spaceY);
            holes[i].Tag = i;
            holes[i].Click += hole_Click;
            panelGame.Controls.Add(holes[i]);

            moles[i] = new Mole(i, holes[i]);
            moles[i].StayTime = config.StayTime;
        }

        ShowGameInfo();
        timer1.Start();
    }

    private void timer1_Tick(object? sender, EventArgs e)
    {
        if (isPause)
        {
            return;
        }

        leftTime--;
        showTimeCount += timer1.Interval;

        for (int i = 0; i < moles.Length; i++)
        {
            if (moles[i].IsShow)
            {
                TimeSpan timeSpan = DateTime.Now - moles[i].ShowTime;

                if (timeSpan.TotalMilliseconds >= moles[i].StayTime)
                {
                    moles[i].IsShow = false;
                    moles[i].Hole.Image = holeImage;
                    stats.MissCount++;
                    stats.Score = Math.Max(0, stats.Score - 5);
                    comboCount = 0;
                    labelTip.Text = "漏掉地鼠，扣 5 分，连击中断。";
                }
            }
        }

        if (showTimeCount >= config.ShowInterval)
        {
            showTimeCount = 0;

            for (int i = 0; i < config.MoleCount; i++)
            {
                ShowRandomMole();
            }
        }

        ShowGameInfo();

        if (leftTime <= 0)
        {
            EndGame();
        }
    }

    private void ShowRandomMole()
    {
        int tryCount = 0;

        while (tryCount < 20)
        {
            int index = random.Next(0, moles.Length);

            if (!moles[index].IsShow)
            {
                moles[index].IsShow = true;
                moles[index].IsGolden = random.Next(0, 100) < 15;
                moles[index].Score = moles[index].IsGolden ? 30 : 10;
                moles[index].ShowTime = DateTime.Now;
                moles[index].Hole.Image = moles[index].IsGolden ? goldMoleImage : moleImage;
                return;
            }

            tryCount++;
        }
    }


    private void hole_Click(object? sender, EventArgs e)
    {
        if (isPause)
        {
            return;
        }

        PictureBox pictureBox = (PictureBox)sender!;
        int index = Convert.ToInt32(pictureBox.Tag);
        stats.ClickCount++;

        if (moles[index].IsShow)
        {
            comboCount++;
            if (comboCount > stats.MaxCombo)
            {
                stats.MaxCombo = comboCount;
            }

            int addScore = moles[index].Score + GetComboBonus();
            stats.Score += addScore;
            stats.HitCount++;
            ShowHitFeedback(index, addScore);
            moles[index].IsShow = false;
            moles[index].Hole.Image = holeImage;
        }

        ShowGameInfo();
    }

    private void panelGame_Click(object? sender, EventArgs e)
    {
        if (!isPause)
        {
            stats.ClickCount++;
            stats.Score = Math.Max(0, stats.Score - 2);
            comboCount = 0;
            labelTip.Text = "点空了，扣 2 分，连击中断。";
            ShowGameInfo();
        }
    }

    private void buttonPause_Click(object? sender, EventArgs e)
    {
        if (isPause)
        {
            isPause = false;
            buttonPause.Text = "暂停";
        }
        else
        {
            isPause = true;
            buttonPause.Text = "继续";
        }
    }

    private void ShowGameInfo()
    {
        labelTime.Text = "时间：" + leftTime / 10 + "秒";
        labelScore.Text = "分数：" + stats.Score;
        labelHit.Text = "命中：" + stats.HitCount;
        labelMiss.Text = "漏掉：" + stats.MissCount;
        labelCombo.Text = "连击：" + comboCount;

        if (leftTime <= 100)
        {
            labelTime.ForeColor = Color.Red;
            if (!labelHitTip.Visible)
            {
                labelTip.Text = "最后 10 秒，加油冲刺！";
            }
        }
        else
        {
            labelTime.ForeColor = Color.Black;
        }
    }

    private int GetComboBonus()
    {
        if (comboCount >= 6)
        {
            return 20;
        }
        else if (comboCount >= 3)
        {
            return 10;
        }
        else
        {
            return 0;
        }
    }

    private void ShowHitFeedback(int index, int addScore)
    {
        labelHitTip.Text = "+" + addScore;
        labelHitTip.Location = new Point(moles[index].Hole.Location.X + 20, moles[index].Hole.Location.Y - 20);
        labelHitTip.Visible = true;
        labelHitTip.BringToFront();

        timerFeedback.Stop();
        timerFeedback.Start();
    }

    private void timerFeedback_Tick(object? sender, EventArgs e)
    {
        timerFeedback.Stop();
        labelHitTip.Visible = false;
        labelTip.Text = "普通地鼠 +10，金色地鼠 +30，连击有加成；漏掉 -5，点空 -2。";
    }

    private void EndGame()
    {
        timer1.Stop();

        for (int i = 0; i < moles.Length; i++)
        {
            if (moles[i].IsShow)
            {
                moles[i].IsShow = false;
                moles[i].Hole.Image = holeImage;
            }
        }

        FormEnd frmEnd = new FormEnd(playerName, config, stats);
        frmEnd.ShowDialog();
        PlayAgain = frmEnd.PlayAgain;
        this.Close();
    }
}
