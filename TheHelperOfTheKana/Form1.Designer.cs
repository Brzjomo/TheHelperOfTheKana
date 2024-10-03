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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            LB_Romaji = new Label();
            LB_Score = new Label();
            BTN_No = new Button();
            BTN_Yes = new Button();
            PB_1 = new PictureBox();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            RB_NotHideImage = new RadioButton();
            RB_HideImage = new RadioButton();
            tabPage3 = new TabPage();
            LB_TopScore = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_1).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(413, 515);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(LB_Romaji);
            tabPage1.Controls.Add(LB_Score);
            tabPage1.Controls.Add(BTN_No);
            tabPage1.Controls.Add(BTN_Yes);
            tabPage1.Controls.Add(PB_1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(405, 481);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "假名";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // LB_Romaji
            // 
            LB_Romaji.Cursor = Cursors.Hand;
            LB_Romaji.Font = new Font("Microsoft YaHei UI", 14F);
            LB_Romaji.ForeColor = Color.IndianRed;
            LB_Romaji.Location = new Point(171, 384);
            LB_Romaji.Name = "LB_Romaji";
            LB_Romaji.Size = new Size(60, 25);
            LB_Romaji.TabIndex = 4;
            LB_Romaji.Text = "tsu";
            LB_Romaji.TextAlign = ContentAlignment.MiddleCenter;
            LB_Romaji.Click += LB_Romaji_Click;
            // 
            // LB_Score
            // 
            LB_Score.Cursor = Cursors.Hand;
            LB_Score.Font = new Font("Microsoft YaHei UI", 14F);
            LB_Score.ForeColor = SystemColors.ActiveCaption;
            LB_Score.Location = new Point(171, 432);
            LB_Score.Name = "LB_Score";
            LB_Score.Size = new Size(60, 25);
            LB_Score.TabIndex = 3;
            LB_Score.Text = "-100";
            LB_Score.TextAlign = ContentAlignment.MiddleCenter;
            LB_Score.Click += LB_Score_Click;
            // 
            // BTN_No
            // 
            BTN_No.Cursor = Cursors.Hand;
            BTN_No.Location = new Point(237, 416);
            BTN_No.Name = "BTN_No";
            BTN_No.Size = new Size(162, 59);
            BTN_No.TabIndex = 2;
            BTN_No.Text = "不记得";
            BTN_No.UseVisualStyleBackColor = true;
            BTN_No.Click += BTN_No_Click;
            // 
            // BTN_Yes
            // 
            BTN_Yes.Cursor = Cursors.Hand;
            BTN_Yes.Location = new Point(6, 416);
            BTN_Yes.Name = "BTN_Yes";
            BTN_Yes.Size = new Size(159, 59);
            BTN_Yes.TabIndex = 1;
            BTN_Yes.Text = "记得";
            BTN_Yes.UseVisualStyleBackColor = true;
            BTN_Yes.Click += BT_Yes_Click;
            // 
            // PB_1
            // 
            PB_1.Cursor = Cursors.Hand;
            PB_1.Location = new Point(6, 6);
            PB_1.Name = "PB_1";
            PB_1.Size = new Size(393, 375);
            PB_1.SizeMode = PictureBoxSizeMode.Zoom;
            PB_1.TabIndex = 0;
            PB_1.TabStop = false;
            PB_1.Click += PB_1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(405, 485);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "设置";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RB_NotHideImage);
            groupBox1.Controls.Add(RB_HideImage);
            groupBox1.Location = new Point(30, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 61);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "默认隐藏图片:";
            // 
            // RB_NotHideImage
            // 
            RB_NotHideImage.AutoSize = true;
            RB_NotHideImage.Location = new Point(243, 27);
            RB_NotHideImage.Name = "RB_NotHideImage";
            RB_NotHideImage.Size = new Size(76, 25);
            RB_NotHideImage.TabIndex = 3;
            RB_NotHideImage.TabStop = true;
            RB_NotHideImage.Text = "不隐藏";
            RB_NotHideImage.UseVisualStyleBackColor = true;
            RB_NotHideImage.CheckedChanged += RB_NotHideImage_CheckedChanged;
            // 
            // RB_HideImage
            // 
            RB_HideImage.AutoSize = true;
            RB_HideImage.Location = new Point(31, 27);
            RB_HideImage.Name = "RB_HideImage";
            RB_HideImage.Size = new Size(60, 25);
            RB_HideImage.TabIndex = 2;
            RB_HideImage.TabStop = true;
            RB_HideImage.Text = "隐藏";
            RB_HideImage.UseVisualStyleBackColor = true;
            RB_HideImage.CheckedChanged += RB_HideImage_CheckedChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(LB_TopScore);
            tabPage3.Controls.Add(label1);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(405, 485);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "记录";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // LB_TopScore
            // 
            LB_TopScore.AutoSize = true;
            LB_TopScore.Location = new Point(98, 22);
            LB_TopScore.Name = "LB_TopScore";
            LB_TopScore.Size = new Size(55, 21);
            LB_TopScore.TabIndex = 1;
            LB_TopScore.Text = "10000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 22);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 0;
            label1.Text = "最高分:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(437, 539);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft YaHei UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "假名记忆助手";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PB_1).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
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
    }
}
