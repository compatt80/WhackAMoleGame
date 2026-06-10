namespace WhackAMoleGame;

partial class FormStart
{
    private Label labelTitle = null!;
    private Label labelName = null!;
    private Label labelLevel = null!;
    private TextBox textBoxName = null!;
    private ComboBox comboBoxLevel = null!;
    private Label labelRule = null!;
    private Button buttonStart = null!;
    private Button buttonExit = null!;

    //protected override void Dispose(bool disposing)
    //{
    //    if (disposing && (components != null))
    //    {
    //        components.Dispose();
    //    }
    //    base.Dispose(disposing);
    //}

    private void InitializeComponent()
    {
        labelTitle = new Label();
        labelName = new Label();
        labelLevel = new Label();
        textBoxName = new TextBox();
        comboBoxLevel = new ComboBox();
        labelRule = new Label();
        buttonStart = new Button();
        buttonExit = new Button();
        SuspendLayout();
        // 
        // labelTitle
        // 
        labelTitle.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Bold);
        labelTitle.ForeColor = Color.FromArgb(91, 59, 29);
        labelTitle.Location = new Point(0, 42);
        labelTitle.Margin = new Padding(4, 0, 4, 0);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(782, 72);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "打地鼠小游戏";
        labelTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // labelName
        // 
        labelName.Font = new Font("Microsoft YaHei UI", 12F);
        labelName.Location = new Point(171, 156);
        labelName.Margin = new Padding(4, 0, 4, 0);
        labelName.Name = "labelName";
        labelName.Size = new Size(165, 43);
        labelName.TabIndex = 1;
        labelName.Text = "玩家姓名：";
        // 
        // labelLevel
        // 
        labelLevel.Font = new Font("Microsoft YaHei UI", 12F);
        labelLevel.Location = new Point(171, 222);
        labelLevel.Margin = new Padding(4, 0, 4, 0);
        labelLevel.Name = "labelLevel";
        labelLevel.Size = new Size(165, 43);
        labelLevel.TabIndex = 3;
        labelLevel.Text = "游戏难度：";
        // 
        // textBoxName
        // 
        textBoxName.Font = new Font("Microsoft YaHei UI", 12F);
        textBoxName.Location = new Point(348, 154);
        textBoxName.Margin = new Padding(4);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(268, 38);
        textBoxName.TabIndex = 2;
        //
        // comboBoxLevel
        // 
        comboBoxLevel.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxLevel.Font = new Font("Microsoft YaHei UI", 12F);
        comboBoxLevel.FormattingEnabled = true;
        comboBoxLevel.Items.AddRange(new object[] { "简单", "普通", "困难" });
        comboBoxLevel.Location = new Point(348, 220);
        comboBoxLevel.Margin = new Padding(4);
        comboBoxLevel.Name = "comboBoxLevel";
        comboBoxLevel.Size = new Size(268, 39);
        comboBoxLevel.TabIndex = 4;
        // 
        // labelRule
        // 
        labelRule.Font = new Font("Microsoft YaHei UI", 10F);
        labelRule.ForeColor = Color.FromArgb(91, 59, 29);
        labelRule.Location = new Point(98, 282);
        labelRule.Margin = new Padding(4, 0, 4, 0);
        labelRule.Name = "labelRule";
        labelRule.Size = new Size(611, 30);
        labelRule.TabIndex = 5;
        labelRule.Text = "普通地鼠 +10，金色地鼠 +30，连击有加成；漏掉和点空会扣分。";
        labelRule.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // buttonStart
        // 
        buttonStart.BackColor = Color.FromArgb(109, 151, 75);
        buttonStart.FlatStyle = FlatStyle.Flat;
        buttonStart.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
        buttonStart.ForeColor = Color.White;
        buttonStart.Location = new Point(232, 318);
        buttonStart.Margin = new Padding(4);
        buttonStart.Name = "buttonStart";
        buttonStart.Size = new Size(165, 55);
        buttonStart.TabIndex = 6;
        buttonStart.Text = "开始游戏";
        buttonStart.UseVisualStyleBackColor = false;
        buttonStart.Click += buttonStart_Click;
        // 
        // buttonExit
        // 
        buttonExit.BackColor = Color.FromArgb(176, 91, 72);
        buttonExit.FlatStyle = FlatStyle.Flat;
        buttonExit.Font = new Font("Microsoft YaHei UI", 12F);
        buttonExit.ForeColor = Color.White;
        buttonExit.Location = new Point(446, 318);
        buttonExit.Margin = new Padding(4);
        buttonExit.Name = "buttonExit";
        buttonExit.Size = new Size(165, 55);
        buttonExit.TabIndex = 7;
        buttonExit.Text = "退出";
        buttonExit.UseVisualStyleBackColor = false;
        buttonExit.Click += buttonExit_Click;
        // 
        // FormStart
        // 
        AutoScaleDimensions = new SizeF(11F, 24F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 239, 219);
        ClientSize = new Size(782, 456);
        Controls.Add(buttonExit);
        Controls.Add(buttonStart);
        Controls.Add(labelRule);
        Controls.Add(comboBoxLevel);
        Controls.Add(textBoxName);
        Controls.Add(labelLevel);
        Controls.Add(labelName);
        Controls.Add(labelTitle);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4);
        MaximizeBox = false;
        Name = "FormStart";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "打地鼠小游戏 - 开始";
        ResumeLayout(false);
        PerformLayout();
    }
}
