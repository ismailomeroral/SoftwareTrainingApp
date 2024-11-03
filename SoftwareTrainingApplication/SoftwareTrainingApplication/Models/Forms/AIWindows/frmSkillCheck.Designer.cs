namespace SoftwareTrainingApplication.Models.Forms.AIWindows
{
    partial class frmSkillCheck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboxDifficulty = new System.Windows.Forms.ComboBox();
            this.cmboxTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chlistboxSubjects = new SoftwareTrainingApplication.Models.UserControls.CheckListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Time";
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnStartQuiz.ForeColor = System.Drawing.Color.White;
            this.btnStartQuiz.Location = new System.Drawing.Point(12, 625);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(326, 46);
            this.btnStartQuiz.TabIndex = 21;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = false;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Difficulty Level";
            // 
            // cmboxDifficulty
            // 
            this.cmboxDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboxDifficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmboxDifficulty.ForeColor = System.Drawing.Color.White;
            this.cmboxDifficulty.FormattingEnabled = true;
            this.cmboxDifficulty.Items.AddRange(new object[] {
            "kolay",
            "orta",
            "zor",
            "çok zor"});
            this.cmboxDifficulty.Location = new System.Drawing.Point(141, 21);
            this.cmboxDifficulty.Name = "cmboxDifficulty";
            this.cmboxDifficulty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmboxDifficulty.Size = new System.Drawing.Size(197, 32);
            this.cmboxDifficulty.TabIndex = 19;
            this.cmboxDifficulty.Text = "kolay";
            // 
            // cmboxTime
            // 
            this.cmboxTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboxTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmboxTime.ForeColor = System.Drawing.Color.White;
            this.cmboxTime.FormattingEnabled = true;
            this.cmboxTime.Items.AddRange(new object[] {
            "3",
            "5",
            "10",
            "15",
            "20",
            "30",
            "45",
            "60",
            "90",
            "120",
            "150",
            "180",
            "limit yok"});
            this.cmboxTime.Location = new System.Drawing.Point(141, 62);
            this.cmboxTime.Name = "cmboxTime";
            this.cmboxTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmboxTime.Size = new System.Drawing.Size(115, 32);
            this.cmboxTime.TabIndex = 22;
            this.cmboxTime.Text = "5";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Minutes";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(55, 27);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(237, 63);
            this.lblTimer.TabIndex = 25;
            this.lblTimer.Text = "00:00:00";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chlistboxSubjects);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmboxDifficulty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmboxTime);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 605);
            this.panel1.TabIndex = 26;
            // 
            // chlistboxSubjects
            // 
            this.chlistboxSubjects.AllCheckItem = false;
            this.chlistboxSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chlistboxSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.chlistboxSubjects.ForeColor = System.Drawing.Color.White;
            this.chlistboxSubjects.ItemsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.chlistboxSubjects.Location = new System.Drawing.Point(12, 116);
            this.chlistboxSubjects.Name = "chlistboxSubjects";
            this.chlistboxSubjects.Size = new System.Drawing.Size(326, 478);
            this.chlistboxSubjects.TabIndex = 18;
            this.chlistboxSubjects.Title = "Programing Subjects";
            // 
            // frmSkillCheck
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(350, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnStartQuiz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSkillCheck";
            this.Text = "SkillCheck";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmboxDifficulty;
        private UserControls.CheckListBox chlistboxSubjects;
        private System.Windows.Forms.ComboBox cmboxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel panel1;
    }
}