namespace WhackAMoleGame;

partial class FormGame
{
    private System.ComponentModel.IContainer components = null!;
    private Label labelPlayer = null!;
    private Label labelTime = null!;
    private Label labelScore = null!;
    private Label labelHit = null!;
    private Label labelMiss = null!;
    private Label labelCombo = null!;
    private Label labelTip = null!;
    private Label labelHitTip = null!;
    private Button buttonPause = null!;
    private Panel panelGame = null!;
    private System.Windows.Forms.Timer timer1 = null!;
    private System.Windows.Forms.Timer timerFeedback = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        labelPlayer = new Label();
        labelTime = new Label();
        labelScore = new Label();
        labelHit = new Label();
        labelMiss = new Label();
        labelCombo = new Label();
        labelTip = new Label();
        labelHitTip = new Label();
        buttonPause = new Button();
        panelGame = new Panel();
        timer1 = new System.Windows.Forms.Timer(components);
        timerFeedback = new System.Windows.Forms.Timer(components);
        panelGame.SuspendLayout();
        SuspendLayout();
        // 
        // labelPlayer
        // 
        labelPlayer.Font = new Font("Microsoft YaHei UI", 11F);
        labelPlayer.Location = new Point(25, 18);
        labelPlayer.Name = "labelPlayer";
        labelPlayer.Size = new Size(140, 32);
        labelPlayer.TabIndex = 0;
        labelPlayer.Text = "玩家：";
        // 
        // labelTime
        // 
        labelTime.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold);
        labelTime.Location = new Point(175, 18);
        labelTime.Name = "labelTime";
        labelTime.Size = new Size(130, 32);
        labelTime.TabIndex = 1;
        labelTime.Text = "时间：";
        // 
        // labelScore
        // 
        labelScore.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold);
        labelScore.Location = new Point(315, 18);
        labelScore.Name = "labelScore";
        labelScore.Size = new Size(135, 32);
        labelScore.TabIndex = 2;
        labelScore.Text = "分数：";
        // 
        // labelHit
        // 
        labelHit.Font = new Font("Microsoft YaHei UI", 11F);
        labelHit.Location = new Point(465, 18);
        labelHit.Name = "labelHit";
        labelHit.Size = new Size(120, 32);
        labelHit.TabIndex = 3;
        labelHit.Text = "命中：";
        // 
        // labelMiss
        // 
        labelMiss.Font = new Font("Microsoft YaHei UI", 11F);
        labelMiss.Location = new Point(595, 18);
        labelMiss.Name = "labelMiss";
        labelMiss.Size = new Size(120, 32);
        labelMiss.TabIndex = 4;
        labelMiss.Text = "漏掉：";
        // 
        // labelCombo
        // 
        labelCombo.Font = new Font("Microsoft YaHei UI", 11F);
        labelCombo.Location = new Point(725, 18);
        labelCombo.Name = "labelCombo";
        labelCombo.Size = new Size(130, 32);
        labelCombo.TabIndex = 5;
        labelCombo.Text = "连击：";
        // 
        // labelTip
        // 
        labelTip.Font = new Font("Microsoft YaHei UI", 10F);
        labelTip.Location = new Point(0, 590);
        labelTip.Name = "labelTip";
        labelTip.Size = new Size(980, 28);
        labelTip.TabIndex = 8;
        labelTip.Text = "普通地鼠 +10，金色地鼠 +30，连击有加成；漏掉 -5，点空 -2。";
        labelTip.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // labelHitTip
        // 
        labelHitTip.BackColor = Color.Transparent;
        labelHitTip.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold);
        labelHitTip.ForeColor = Color.FromArgb(255, 245, 180);
        labelHitTip.Location = new Point(0, 0);
        labelHitTip.Name = "labelHitTip";
        labelHitTip.Size = new Size(80, 36);
        labelHitTip.TabIndex = 0;
        labelHitTip.Text = "+10";
        labelHitTip.TextAlign = ContentAlignment.MiddleCenter;
        labelHitTip.Visible = false;
        // 
        // buttonPause
        // 
        buttonPause.Font = new Font("Microsoft YaHei UI", 10F);
        buttonPause.Location = new Point(875, 14);
        buttonPause.Name = "buttonPause";
        buttonPause.Size = new Size(80, 36);
        buttonPause.TabIndex = 6;
        buttonPause.Text = "暂停";
        buttonPause.Click += buttonPause_Click;
        // 
        // panelGame
        // 
        panelGame.BackColor = Color.FromArgb(132, 180, 98);
        panelGame.BorderStyle = BorderStyle.FixedSingle;
        panelGame.Controls.Add(labelHitTip);
        panelGame.Location = new Point(180, 70);
        panelGame.Name = "panelGame";
        panelGame.Size = new Size(620, 500);
        panelGame.TabIndex = 7;
        panelGame.Click += panelGame_Click;
        // 
        // timer1
        // 
        timer1.Interval = 100;
        timer1.Tick += timer1_Tick;
        // 
        // timerFeedback
        // 
        timerFeedback.Interval = 350;
        timerFeedback.Tick += timerFeedback_Tick;
        // 
        // FormGame
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(236, 244, 225);
        ClientSize = new Size(980, 650);
        Controls.Add(labelTip);
        Controls.Add(panelGame);
        Controls.Add(buttonPause);
        Controls.Add(labelCombo);
        Controls.Add(labelMiss);
        Controls.Add(labelHit);
        Controls.Add(labelScore);
        Controls.Add(labelTime);
        Controls.Add(labelPlayer);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormGame";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "打地鼠小游戏 - 游戏中";
        panelGame.ResumeLayout(false);
        ResumeLayout(false);
    }
}
