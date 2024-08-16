namespace UTS_PAD_REMAKE
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
            components = new System.ComponentModel.Container();
            spawn_leftTop = new Button();
            spawn_leftMid = new Button();
            spawn_leftBot = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            spawn_rightTop = new Button();
            spawn_rightMid = new Button();
            spawn_rightBot = new Button();
            CrashTimer = new System.Windows.Forms.Timer(components);
            AnimatorTimer = new System.Windows.Forms.Timer(components);
            SpawnTimer = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            pr_label = new Label();
            label3 = new Label();
            pl_label = new Label();
            label1 = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            panel4 = new Panel();
            timeLabel = new Label();
            label2 = new Label();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // spawn_leftTop
            // 
            spawn_leftTop.Location = new Point(12, 99);
            spawn_leftTop.Name = "spawn_leftTop";
            spawn_leftTop.Size = new Size(80, 80);
            spawn_leftTop.TabIndex = 0;
            spawn_leftTop.Text = "SPAWN";
            spawn_leftTop.UseVisualStyleBackColor = true;
            spawn_leftTop.Click += spawn_leftTop_Click;
            // 
            // spawn_leftMid
            // 
            spawn_leftMid.Location = new Point(12, 209);
            spawn_leftMid.Name = "spawn_leftMid";
            spawn_leftMid.Size = new Size(80, 80);
            spawn_leftMid.TabIndex = 1;
            spawn_leftMid.Text = "SPAWN";
            spawn_leftMid.UseVisualStyleBackColor = true;
            spawn_leftMid.Click += spawn_leftMid_Click;
            // 
            // spawn_leftBot
            // 
            spawn_leftBot.Location = new Point(12, 319);
            spawn_leftBot.Name = "spawn_leftBot";
            spawn_leftBot.Size = new Size(80, 80);
            spawn_leftBot.TabIndex = 2;
            spawn_leftBot.Text = "SPAWN";
            spawn_leftBot.UseVisualStyleBackColor = true;
            spawn_leftBot.Click += spawn_leftBot_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Location = new Point(-8, 295);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 18);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SaddleBrown;
            panel2.Location = new Point(-8, 185);
            panel2.Name = "panel2";
            panel2.Size = new Size(814, 18);
            panel2.TabIndex = 4;
            // 
            // spawn_rightTop
            // 
            spawn_rightTop.Location = new Point(708, 99);
            spawn_rightTop.Name = "spawn_rightTop";
            spawn_rightTop.Size = new Size(80, 80);
            spawn_rightTop.TabIndex = 5;
            spawn_rightTop.Text = "SPAWN";
            spawn_rightTop.UseVisualStyleBackColor = true;
            spawn_rightTop.Click += spawn_rightTop_Click;
            // 
            // spawn_rightMid
            // 
            spawn_rightMid.Location = new Point(708, 209);
            spawn_rightMid.Name = "spawn_rightMid";
            spawn_rightMid.Size = new Size(80, 80);
            spawn_rightMid.TabIndex = 6;
            spawn_rightMid.Text = "SPAWN";
            spawn_rightMid.UseVisualStyleBackColor = true;
            spawn_rightMid.Click += spawn_rightMid_Click;
            // 
            // spawn_rightBot
            // 
            spawn_rightBot.Location = new Point(708, 324);
            spawn_rightBot.Name = "spawn_rightBot";
            spawn_rightBot.Size = new Size(80, 80);
            spawn_rightBot.TabIndex = 7;
            spawn_rightBot.Text = "SPAWN";
            spawn_rightBot.UseVisualStyleBackColor = true;
            spawn_rightBot.Click += spawn_rightBot_Click;
            // 
            // CrashTimer
            // 
            CrashTimer.Enabled = true;
            CrashTimer.Interval = 50;
            CrashTimer.Tick += CrashTimer_Tick;
            // 
            // AnimatorTimer
            // 
            AnimatorTimer.Enabled = true;
            AnimatorTimer.Interval = 50;
            AnimatorTimer.Tick += AnimatorTimer_Tick;
            // 
            // SpawnTimer
            // 
            SpawnTimer.Enabled = true;
            SpawnTimer.Interval = 1000;
            SpawnTimer.Tick += SpawnTimer_Tick;
            // 
            // panel3
            // 
            panel3.Controls.Add(pr_label);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pl_label);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(501, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(287, 81);
            panel3.TabIndex = 8;
            // 
            // pr_label
            // 
            pr_label.AutoSize = true;
            pr_label.Location = new Point(105, 41);
            pr_label.Name = "pr_label";
            pr_label.Size = new Size(50, 20);
            pr_label.TabIndex = 3;
            pr_label.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 41);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 2;
            label3.Text = "Player Right :";
            // 
            // pl_label
            // 
            pl_label.AutoSize = true;
            pl_label.Location = new Point(105, 9);
            pl_label.Name = "pl_label";
            pl_label.Size = new Size(50, 20);
            pl_label.TabIndex = 1;
            pl_label.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Player Left :";
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 1000;
            GameTimer.Tick += GameTimer_Tick;
            // 
            // panel4
            // 
            panel4.Controls.Add(timeLabel);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(236, 61);
            panel4.TabIndex = 9;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(99, 19);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(44, 20);
            timeLabel.TabIndex = 2;
            timeLabel.Text = "2 : 00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 19);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Time Left :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(800, 416);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(spawn_rightBot);
            Controls.Add(spawn_rightMid);
            Controls.Add(spawn_rightTop);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(spawn_leftBot);
            Controls.Add(spawn_leftMid);
            Controls.Add(spawn_leftTop);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button spawn_leftTop;
        private Button spawn_leftMid;
        private Button spawn_leftBot;
        private Panel panel1;
        private Panel panel2;
        private Button spawn_rightTop;
        private Button spawn_rightMid;
        private Button spawn_rightBot;
        private System.Windows.Forms.Timer CrashTimer;
        private System.Windows.Forms.Timer AnimatorTimer;
        private System.Windows.Forms.Timer SpawnTimer;
        private Panel panel3;
        private Label pr_label;
        private Label label3;
        private Label pl_label;
        private Label label1;
        private System.Windows.Forms.Timer GameTimer;
        private Panel panel4;
        private Label timeLabel;
        private Label label2;
    }
}
