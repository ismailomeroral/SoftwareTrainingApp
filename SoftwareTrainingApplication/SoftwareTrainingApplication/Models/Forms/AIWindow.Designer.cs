namespace SoftwareTrainingApplication.Models.Forms
{
    partial class AIWindow
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
            this.pnlLeftAIMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAIBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.customPanel5 = new SoftwareTrainingApplication.Models.Tools.CustomPanel();
            this.btnAI = new System.Windows.Forms.PictureBox();
            this.customPanel1 = new SoftwareTrainingApplication.Models.Tools.CustomPanel();
            this.btnAskNow = new SoftwareTrainingApplication.Models.Tools.RotateLabel();
            this.customPanel2 = new SoftwareTrainingApplication.Models.Tools.CustomPanel();
            this.btnSkillCheck = new SoftwareTrainingApplication.Models.Tools.RotateLabel();
            this.customPanel3 = new SoftwareTrainingApplication.Models.Tools.CustomPanel();
            this.btnAppGen = new SoftwareTrainingApplication.Models.Tools.RotateLabel();
            this.customPanel4 = new SoftwareTrainingApplication.Models.Tools.CustomPanel();
            this.btnLibrary = new SoftwareTrainingApplication.Models.Tools.RotateLabel();
            this.pnlLeftAIMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.customPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAI)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.customPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftAIMenu
            // 
            this.pnlLeftAIMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlLeftAIMenu.Controls.Add(this.customPanel5);
            this.pnlLeftAIMenu.Controls.Add(this.customPanel1);
            this.pnlLeftAIMenu.Controls.Add(this.customPanel2);
            this.pnlLeftAIMenu.Controls.Add(this.customPanel3);
            this.pnlLeftAIMenu.Controls.Add(this.customPanel4);
            this.pnlLeftAIMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftAIMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlLeftAIMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftAIMenu.Name = "pnlLeftAIMenu";
            this.pnlLeftAIMenu.Size = new System.Drawing.Size(46, 729);
            this.pnlLeftAIMenu.TabIndex = 4;
            // 
            // pnlAIBody
            // 
            this.pnlAIBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAIBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlAIBody.Location = new System.Drawing.Point(46, 46);
            this.pnlAIBody.Name = "pnlAIBody";
            this.pnlAIBody.Size = new System.Drawing.Size(304, 683);
            this.pnlAIBody.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(46, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 46);
            this.panel1.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(6, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "AI Window";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customPanel5
            // 
            this.customPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.customPanel5.BottomLeftRadius = 10;
            this.customPanel5.BottomRightRadius = 0;
            this.customPanel5.Controls.Add(this.btnAI);
            this.customPanel5.Location = new System.Drawing.Point(3, 3);
            this.customPanel5.MinimumSize = new System.Drawing.Size(10, 20);
            this.customPanel5.Name = "customPanel5";
            this.customPanel5.Size = new System.Drawing.Size(40, 40);
            this.customPanel5.TabIndex = 14;
            this.customPanel5.TopLeftRadius = 10;
            this.customPanel5.TopRightRadius = 0;
            // 
            // btnAI
            // 
            this.btnAI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAI.Image = global::SoftwareTrainingApplication.Properties.Resources.AILogo;
            this.btnAI.Location = new System.Drawing.Point(0, 0);
            this.btnAI.Name = "btnAI";
            this.btnAI.Padding = new System.Windows.Forms.Padding(4);
            this.btnAI.Size = new System.Drawing.Size(40, 40);
            this.btnAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAI.TabIndex = 0;
            this.btnAI.TabStop = false;
            this.btnAI.Click += new System.EventHandler(this.btnAIwindow_Click);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.customPanel1.BottomLeftRadius = 10;
            this.customPanel1.BottomRightRadius = 0;
            this.customPanel1.Controls.Add(this.btnAskNow);
            this.customPanel1.Location = new System.Drawing.Point(3, 49);
            this.customPanel1.MinimumSize = new System.Drawing.Size(10, 20);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(40, 98);
            this.customPanel1.TabIndex = 0;
            this.customPanel1.TopLeftRadius = 10;
            this.customPanel1.TopRightRadius = 0;
            // 
            // btnAskNow
            // 
            this.btnAskNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAskNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAskNow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAskNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAskNow.ForeColor = System.Drawing.Color.White;
            this.btnAskNow.Location = new System.Drawing.Point(0, 0);
            this.btnAskNow.Name = "btnAskNow";
            this.btnAskNow.RotationAngle = -90F;
            this.btnAskNow.Size = new System.Drawing.Size(40, 98);
            this.btnAskNow.TabIndex = 0;
            this.btnAskNow.Text = "Ask Now";
            this.btnAskNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAskNow.Click += new System.EventHandler(this.btnShowAskNow_Click);
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.customPanel2.BottomLeftRadius = 10;
            this.customPanel2.BottomRightRadius = 0;
            this.customPanel2.Controls.Add(this.btnSkillCheck);
            this.customPanel2.Location = new System.Drawing.Point(3, 153);
            this.customPanel2.MinimumSize = new System.Drawing.Size(10, 20);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(40, 114);
            this.customPanel2.TabIndex = 11;
            this.customPanel2.TopLeftRadius = 10;
            this.customPanel2.TopRightRadius = 0;
            // 
            // btnSkillCheck
            // 
            this.btnSkillCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSkillCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkillCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSkillCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSkillCheck.ForeColor = System.Drawing.Color.White;
            this.btnSkillCheck.Location = new System.Drawing.Point(0, 0);
            this.btnSkillCheck.Name = "btnSkillCheck";
            this.btnSkillCheck.RotationAngle = -90F;
            this.btnSkillCheck.Size = new System.Drawing.Size(40, 114);
            this.btnSkillCheck.TabIndex = 0;
            this.btnSkillCheck.Text = "Skill Check";
            this.btnSkillCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSkillCheck.Click += new System.EventHandler(this.btnShowSkillCheck_Click);
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.customPanel3.BottomLeftRadius = 10;
            this.customPanel3.BottomRightRadius = 0;
            this.customPanel3.Controls.Add(this.btnAppGen);
            this.customPanel3.Location = new System.Drawing.Point(3, 273);
            this.customPanel3.MinimumSize = new System.Drawing.Size(10, 20);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(40, 98);
            this.customPanel3.TabIndex = 12;
            this.customPanel3.TopLeftRadius = 10;
            this.customPanel3.TopRightRadius = 0;
            this.customPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel3_Paint);
            // 
            // btnAppGen
            // 
            this.btnAppGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAppGen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppGen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAppGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAppGen.ForeColor = System.Drawing.Color.White;
            this.btnAppGen.Location = new System.Drawing.Point(0, 0);
            this.btnAppGen.Name = "btnAppGen";
            this.btnAppGen.RotationAngle = -90F;
            this.btnAppGen.Size = new System.Drawing.Size(40, 98);
            this.btnAppGen.TabIndex = 0;
            this.btnAppGen.Text = "App Gen";
            this.btnAppGen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAppGen.Click += new System.EventHandler(this.btnShowAppGen_Click);
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.customPanel4.BottomLeftRadius = 10;
            this.customPanel4.BottomRightRadius = 0;
            this.customPanel4.Controls.Add(this.btnLibrary);
            this.customPanel4.Location = new System.Drawing.Point(3, 377);
            this.customPanel4.MinimumSize = new System.Drawing.Size(10, 20);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(40, 81);
            this.customPanel4.TabIndex = 13;
            this.customPanel4.TopLeftRadius = 10;
            this.customPanel4.TopRightRadius = 0;
            this.customPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel4_Paint);
            // 
            // btnLibrary
            // 
            this.btnLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLibrary.ForeColor = System.Drawing.Color.White;
            this.btnLibrary.Location = new System.Drawing.Point(0, 0);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.RotationAngle = -90F;
            this.btnLibrary.Size = new System.Drawing.Size(40, 81);
            this.btnLibrary.TabIndex = 0;
            this.btnLibrary.Text = "Library";
            this.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLibrary.Click += new System.EventHandler(this.btnShowLibrary_Click);
            // 
            // AIWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLeftAIMenu);
            this.Controls.Add(this.pnlAIBody);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AIWindow";
            this.Text = "AIWindow";
            this.pnlLeftAIMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.customPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAI)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel3.ResumeLayout(false);
            this.customPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnlLeftAIMenu;
        private System.Windows.Forms.Panel pnlAIBody;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private Tools.CustomPanel customPanel1;
        private Tools.RotateLabel btnAskNow;
        private Tools.CustomPanel customPanel2;
        private Tools.RotateLabel btnSkillCheck;
        private Tools.CustomPanel customPanel3;
        private Tools.RotateLabel btnAppGen;
        private Tools.CustomPanel customPanel4;
        private Tools.RotateLabel btnLibrary;
        private Tools.CustomPanel customPanel5;
        private System.Windows.Forms.PictureBox btnAI;
    }
}