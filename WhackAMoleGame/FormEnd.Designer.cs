namespace WhackAMoleGame;

partial class FormEnd
{
    private System.ComponentModel.IContainer components = null!;
    private Label labelTitle = null!;
    private Label labelInfo = null!;
    private Button buttonAgain = null!;
    private Button buttonBack = null!;

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
        labelTitle = new Label();
        labelInfo = new Label();
        buttonAgain = new Button();
        buttonBack = new Button();
        SuspendLayout();
        // 
        // labelTitle
        // 
        labelTitle.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold);
        labelTitle.ForeColor = Color.FromArgb(91, 59, 29);
        labelTitle.Location = new Point(0, 36);
        labelTitle.Margin = new Padding(4, 0, 4, 0);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(758, 66);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "游戏结束";
        labelTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // labelInfo
        // 
        labelInfo.Font = new Font("Microsoft YaHei UI", 12F);
        labelInfo.Location = new Point(116, 120);
        labelInfo.Margin = new Padding(4, 0, 4, 0);
        labelInfo.Name = "labelInfo";
        labelInfo.Size = new Size(526, 276);
        labelInfo.TabIndex = 1;
        labelInfo.Text = "玩家：\r\n难度：\r\n最终得分：\r\n命中次数：    漏掉次数：\r\n命中率：\r\n最高连击：\r\n评价等级：";
        // 
        // buttonAgain
        // 
        buttonAgain.BackColor = Color.FromArgb(109, 151, 75);
        buttonAgain.FlatStyle = FlatStyle.Flat;
        buttonAgain.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold);
        buttonAgain.ForeColor = Color.White;
        buttonAgain.Location = new Point(183, 444);
        buttonAgain.Margin = new Padding(4, 4, 4, 4);
        buttonAgain.Name = "buttonAgain";
        buttonAgain.Size = new Size(177, 55);
        buttonAgain.TabIndex = 2;
        buttonAgain.Text = "再玩一次";
        buttonAgain.UseVisualStyleBackColor = false;
        buttonAgain.Click += buttonAgain_Click;
        // 
        // buttonBack
        // 
        buttonBack.BackColor = Color.FromArgb(176, 91, 72);
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.Font = new Font("Microsoft YaHei UI", 11F);
        buttonBack.ForeColor = Color.White;
        buttonBack.Location = new Point(422, 444);
        buttonBack.Margin = new Padding(4, 4, 4, 4);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(177, 55);
        buttonBack.TabIndex = 3;
        buttonBack.Text = "返回开始";
        buttonBack.UseVisualStyleBackColor = false;
        buttonBack.Click += buttonBack_Click;
        // 
        // FormEnd
        // 
        AutoScaleDimensions = new SizeF(11F, 24F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 239, 219);
        ClientSize = new Size(758, 564);
        Controls.Add(buttonBack);
        Controls.Add(buttonAgain);
        Controls.Add(labelInfo);
        Controls.Add(labelTitle);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 4, 4, 4);
        MaximizeBox = false;
        Name = "FormEnd";
        StartPosition = FormStartPosition.CenterParent;
        Text = "打地鼠小游戏 - 游戏结束";
        ResumeLayout(false);
    }
}
