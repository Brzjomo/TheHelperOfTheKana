namespace TheHelperOfTheKana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            PB_1 = new PictureBox();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            BTN_Yes = new Button();
            LB_Score = new Label();
            LB_Romaji = new Label();
            BTN_No = new Button();
            tabPage2 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            RB_HideImage = new RadioButton();
            RB_NotHideImage = new RadioButton();
            groupBox3 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            CB_Voiced = new CheckBox();
            CB_Unvoiced = new CheckBox();
            CB_SemiVoiced = new CheckBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            RB_Hiragana = new RadioButton();
            RB_All = new RadioButton();
            RB_Katakana = new RadioButton();
            tabPage3 = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            LB_TopScore = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tabPage3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(415, 526);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(407, 492);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "假名";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(PB_1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(401, 486);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // PB_1
            // 
            PB_1.Cursor = Cursors.Hand;
            PB_1.Dock = DockStyle.Fill;
            PB_1.Location = new Point(3, 3);
            PB_1.Name = "PB_1";
            PB_1.Size = new Size(395, 358);
            PB_1.SizeMode = PictureBoxSizeMode.Zoom;
            PB_1.TabIndex = 0;
            PB_1.TabStop = false;
            PB_1.Click += PB_1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 367);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 116);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(BTN_Yes, 0, 1);
            tableLayoutPanel2.Controls.Add(LB_Score, 2, 1);
            tableLayoutPanel2.Controls.Add(LB_Romaji, 2, 0);
            tableLayoutPanel2.Controls.Add(BTN_No, 3, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Size = new Size(395, 116);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // BTN_Yes
            // 
            tableLayoutPanel2.SetColumnSpan(BTN_Yes, 2);
            BTN_Yes.Cursor = Cursors.Hand;
            BTN_Yes.Dock = DockStyle.Fill;
            BTN_Yes.Location = new Point(3, 37);
            BTN_Yes.Name = "BTN_Yes";
            BTN_Yes.Size = new Size(152, 76);
            BTN_Yes.TabIndex = 1;
            BTN_Yes.Text = "记得";
            BTN_Yes.UseVisualStyleBackColor = true;
            BTN_Yes.Click += BT_Yes_Click;
            // 
            // LB_Score
            // 
            LB_Score.Cursor = Cursors.Hand;
            LB_Score.Dock = DockStyle.Fill;
            LB_Score.Font = new Font("Microsoft YaHei UI", 14F);
            LB_Score.ForeColor = SystemColors.ActiveCaption;
            LB_Score.Location = new Point(161, 34);
            LB_Score.Name = "LB_Score";
            LB_Score.Size = new Size(73, 82);
            LB_Score.TabIndex = 3;
            LB_Score.Text = "-100";
            LB_Score.TextAlign = ContentAlignment.MiddleCenter;
            LB_Score.Click += LB_Score_Click;
            // 
            // LB_Romaji
            // 
            LB_Romaji.Cursor = Cursors.Hand;
            LB_Romaji.Dock = DockStyle.Fill;
            LB_Romaji.Font = new Font("Microsoft YaHei UI", 14F);
            LB_Romaji.ForeColor = Color.IndianRed;
            LB_Romaji.Location = new Point(161, 0);
            LB_Romaji.Name = "LB_Romaji";
            LB_Romaji.Size = new Size(73, 34);
            LB_Romaji.TabIndex = 4;
            LB_Romaji.Text = "tsu";
            LB_Romaji.TextAlign = ContentAlignment.MiddleCenter;
            LB_Romaji.Click += LB_Romaji_Click;
            // 
            // BTN_No
            // 
            tableLayoutPanel2.SetColumnSpan(BTN_No, 2);
            BTN_No.Cursor = Cursors.Hand;
            BTN_No.Dock = DockStyle.Fill;
            BTN_No.Location = new Point(240, 37);
            BTN_No.Name = "BTN_No";
            BTN_No.Size = new Size(152, 76);
            BTN_No.TabIndex = 2;
            BTN_No.Text = "不记得";
            BTN_No.UseVisualStyleBackColor = true;
            BTN_No.Click += BTN_No_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel3);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(407, 496);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "设置";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel3.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(401, 490);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel8);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 92);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "默认隐藏图片:";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.Controls.Add(RB_HideImage, 0, 0);
            tableLayoutPanel8.Controls.Add(RB_NotHideImage, 2, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 24);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle());
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(389, 65);
            tableLayoutPanel8.TabIndex = 6;
            // 
            // RB_HideImage
            // 
            RB_HideImage.AutoSize = true;
            RB_HideImage.Dock = DockStyle.Fill;
            RB_HideImage.Location = new Point(3, 3);
            RB_HideImage.Name = "RB_HideImage";
            RB_HideImage.Size = new Size(123, 59);
            RB_HideImage.TabIndex = 2;
            RB_HideImage.TabStop = true;
            RB_HideImage.Text = "隐藏";
            RB_HideImage.UseVisualStyleBackColor = true;
            RB_HideImage.CheckedChanged += RB_HideImage_CheckedChanged;
            // 
            // RB_NotHideImage
            // 
            RB_NotHideImage.AutoSize = true;
            RB_NotHideImage.Dock = DockStyle.Fill;
            RB_NotHideImage.Location = new Point(261, 3);
            RB_NotHideImage.Name = "RB_NotHideImage";
            RB_NotHideImage.Size = new Size(125, 59);
            RB_NotHideImage.TabIndex = 3;
            RB_NotHideImage.TabStop = true;
            RB_NotHideImage.Text = "不隐藏";
            RB_NotHideImage.UseVisualStyleBackColor = true;
            RB_NotHideImage.CheckedChanged += RB_NotHideImage_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel6);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 199);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(395, 92);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "显示种类";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.Controls.Add(CB_Voiced, 2, 0);
            tableLayoutPanel6.Controls.Add(CB_Unvoiced, 0, 0);
            tableLayoutPanel6.Controls.Add(CB_SemiVoiced, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 24);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(389, 65);
            tableLayoutPanel6.TabIndex = 6;
            // 
            // CB_Voiced
            // 
            CB_Voiced.AutoSize = true;
            CB_Voiced.Dock = DockStyle.Fill;
            CB_Voiced.Location = new Point(261, 3);
            CB_Voiced.Name = "CB_Voiced";
            CB_Voiced.Size = new Size(125, 59);
            CB_Voiced.TabIndex = 8;
            CB_Voiced.Text = "浊音";
            CB_Voiced.UseVisualStyleBackColor = true;
            CB_Voiced.CheckedChanged += CB_Voiced_CheckedChanged;
            // 
            // CB_Unvoiced
            // 
            CB_Unvoiced.AutoSize = true;
            CB_Unvoiced.Dock = DockStyle.Fill;
            CB_Unvoiced.Location = new Point(3, 3);
            CB_Unvoiced.Name = "CB_Unvoiced";
            CB_Unvoiced.Size = new Size(123, 59);
            CB_Unvoiced.TabIndex = 6;
            CB_Unvoiced.Text = "清音";
            CB_Unvoiced.UseVisualStyleBackColor = true;
            CB_Unvoiced.CheckedChanged += CB_Unvoiced_CheckedChanged;
            // 
            // CB_SemiVoiced
            // 
            CB_SemiVoiced.AutoSize = true;
            CB_SemiVoiced.Dock = DockStyle.Fill;
            CB_SemiVoiced.Location = new Point(132, 3);
            CB_SemiVoiced.Name = "CB_SemiVoiced";
            CB_SemiVoiced.Size = new Size(123, 59);
            CB_SemiVoiced.TabIndex = 7;
            CB_SemiVoiced.Text = "半浊音";
            CB_SemiVoiced.UseVisualStyleBackColor = true;
            CB_SemiVoiced.CheckedChanged += CB_SemiVoiced_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel7);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(395, 92);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "显示假名:";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.Controls.Add(RB_Hiragana, 0, 0);
            tableLayoutPanel7.Controls.Add(RB_All, 2, 0);
            tableLayoutPanel7.Controls.Add(RB_Katakana, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 24);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(389, 65);
            tableLayoutPanel7.TabIndex = 5;
            // 
            // RB_Hiragana
            // 
            RB_Hiragana.AutoSize = true;
            RB_Hiragana.Dock = DockStyle.Fill;
            RB_Hiragana.Location = new Point(3, 3);
            RB_Hiragana.Name = "RB_Hiragana";
            RB_Hiragana.Size = new Size(123, 59);
            RB_Hiragana.TabIndex = 2;
            RB_Hiragana.TabStop = true;
            RB_Hiragana.Text = "平假名";
            RB_Hiragana.UseVisualStyleBackColor = true;
            RB_Hiragana.CheckedChanged += RB_Hiragana_CheckedChanged;
            // 
            // RB_All
            // 
            RB_All.AutoSize = true;
            RB_All.Dock = DockStyle.Fill;
            RB_All.Location = new Point(261, 3);
            RB_All.Name = "RB_All";
            RB_All.Size = new Size(125, 59);
            RB_All.TabIndex = 4;
            RB_All.TabStop = true;
            RB_All.Text = "全部";
            RB_All.UseVisualStyleBackColor = true;
            RB_All.CheckedChanged += RB_All_CheckedChanged;
            // 
            // RB_Katakana
            // 
            RB_Katakana.AutoSize = true;
            RB_Katakana.Dock = DockStyle.Fill;
            RB_Katakana.Location = new Point(132, 3);
            RB_Katakana.Name = "RB_Katakana";
            RB_Katakana.Size = new Size(123, 59);
            RB_Katakana.TabIndex = 3;
            RB_Katakana.TabStop = true;
            RB_Katakana.Text = "片假名";
            RB_Katakana.UseVisualStyleBackColor = true;
            RB_Katakana.CheckedChanged += RB_Katakana_CheckedChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel4);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(407, 496);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "记录";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 10;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.Size = new Size(401, 490);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(LB_TopScore, 1, 0);
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(395, 43);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // LB_TopScore
            // 
            LB_TopScore.AutoSize = true;
            LB_TopScore.Dock = DockStyle.Fill;
            LB_TopScore.Location = new Point(200, 0);
            LB_TopScore.Name = "LB_TopScore";
            LB_TopScore.Size = new Size(192, 43);
            LB_TopScore.TabIndex = 1;
            LB_TopScore.Text = "10000";
            LB_TopScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 43);
            label1.TabIndex = 0;
            label1.Text = "最高分:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(415, 526);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft YaHei UI", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(431, 565);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "假名记忆助手";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PB_1).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tabPage3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox PB_1;
        private Button BTN_No;
        private Button BTN_Yes;
        private Label LB_Score;
        private TabPage tabPage3;
        private Label LB_TopScore;
        private Label label1;
        private Label LB_Romaji;
        private GroupBox groupBox1;
        private RadioButton RB_NotHideImage;
        private RadioButton RB_HideImage;
        private GroupBox groupBox2;
        private RadioButton RB_Katakana;
        private RadioButton RB_Hiragana;
        private GroupBox groupBox3;
        private RadioButton RB_All;
        private CheckBox CB_Voiced;
        private CheckBox CB_SemiVoiced;
        private CheckBox CB_Unvoiced;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel7;
    }
}
