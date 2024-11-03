namespace SoftwareTrainingApplication
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlDesktopWindow = new System.Windows.Forms.Panel();
            this.pnlAIWindow = new System.Windows.Forms.Panel();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeBenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnCloseApp = new System.Windows.Forms.PictureBox();
            this.pnlForm.SuspendLayout();
            this.pnlBar.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pnlForm.Controls.Add(this.pnlDesktopWindow);
            this.pnlForm.Controls.Add(this.pnlAIWindow);
            this.pnlForm.Controls.Add(this.pnlBar);
            this.pnlForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlForm.Location = new System.Drawing.Point(3, 3);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1360, 762);
            this.pnlForm.TabIndex = 0;
            // 
            // pnlDesktopWindow
            // 
            this.pnlDesktopWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlDesktopWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktopWindow.Location = new System.Drawing.Point(0, 30);
            this.pnlDesktopWindow.Name = "pnlDesktopWindow";
            this.pnlDesktopWindow.Size = new System.Drawing.Size(1314, 732);
            this.pnlDesktopWindow.TabIndex = 6;
            // 
            // pnlAIWindow
            // 
            this.pnlAIWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlAIWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAIWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.pnlAIWindow.Location = new System.Drawing.Point(1314, 30);
            this.pnlAIWindow.Name = "pnlAIWindow";
            this.pnlAIWindow.Size = new System.Drawing.Size(46, 732);
            this.pnlAIWindow.TabIndex = 5;
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlBar.Controls.Add(this.menuStrip);
            this.pnlBar.Controls.Add(this.panel1);
            this.pnlBar.Controls.Add(this.btnMin);
            this.pnlBar.Controls.Add(this.btnMax);
            this.pnlBar.Controls.Add(this.btnCloseApp);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(1360, 30);
            this.pnlBar.TabIndex = 0;
            this.pnlBar.DoubleClick += new System.EventHandler(this.btnMax_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabsToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip.Location = new System.Drawing.Point(30, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(77, 30);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tabsToolStripMenuItem
            // 
            this.tabsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.tabsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.tabsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tabsToolStripMenuItem.Name = "tabsToolStripMenuItem";
            this.tabsToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.tabsToolStripMenuItem.Text = "Window";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.newToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeToolStripMenuItem,
            this.codeBenchToolStripMenuItem});
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.newToolStripMenuItem.Text = "New";
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.codeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.codeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("codeToolStripMenuItem.Image")));
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.codeToolStripMenuItem.Text = "Code";
            this.codeToolStripMenuItem.Click += new System.EventHandler(this.codeToolStripMenuItem_Click);
            // 
            // codeBenchToolStripMenuItem
            // 
            this.codeBenchToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.codeBenchToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.codeBenchToolStripMenuItem.Image = global::SoftwareTrainingApplication.Properties.Resources.Blockly;
            this.codeBenchToolStripMenuItem.Name = "codeBenchToolStripMenuItem";
            this.codeBenchToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.codeBenchToolStripMenuItem.Text = "Code Bench";
            this.codeBenchToolStripMenuItem.Click += new System.EventHandler(this.codeBenchToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SoftwareTrainingApplication.Properties.Resources.AILogo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 3;
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.Image = global::SoftwareTrainingApplication.Properties.Resources.Min;
            this.btnMin.Location = new System.Drawing.Point(1270, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Padding = new System.Windows.Forms.Padding(9);
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.Image = global::SoftwareTrainingApplication.Properties.Resources.Maximize;
            this.btnMax.Location = new System.Drawing.Point(1300, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Padding = new System.Windows.Forms.Padding(6);
            this.btnMax.Size = new System.Drawing.Size(30, 30);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMax.TabIndex = 1;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseApp.Image = global::SoftwareTrainingApplication.Properties.Resources.Close;
            this.btnCloseApp.Location = new System.Drawing.Point(1330, 0);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Padding = new System.Windows.Forms.Padding(7);
            this.btnCloseApp.Size = new System.Drawing.Size(30, 30);
            this.btnCloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloseApp.TabIndex = 0;
            this.btnCloseApp.TabStop = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.pnlForm.ResumeLayout(false);
            this.pnlBar.ResumeLayout(false);
            this.pnlBar.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.PictureBox btnCloseApp;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeBenchToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDesktopWindow;
        private System.Windows.Forms.Panel pnlAIWindow;
    }
}