namespace SoftwareTrainingApplication.Models.UserControls
{
    partial class WindowTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new SoftwareTrainingApplication.Models.Tools.CustomPanel();
            this.lblText = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel.BottomLeftRadius = 0;
            this.panel.BottomRightRadius = 0;
            this.panel.Controls.Add(this.lblText);
            this.panel.Controls.Add(this.btnClose);
            this.panel.Controls.Add(this.pctLogo);
            this.panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.MinimumSize = new System.Drawing.Size(10, 10);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(150, 30);
            this.panel.TabIndex = 0;
            this.panel.TopLeftRadius = 0;
            this.panel.TopRightRadius = 10;
            this.panel.Click += new System.EventHandler(this.WindowTab_Click);
            this.panel.MouseEnter += new System.EventHandler(this.WindowTab_MouseEnter);
            this.panel.MouseLeave += new System.EventHandler(this.WindowTab_MouseLeave);
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(32, 8);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(83, 14);
            this.lblText.TabIndex = 5;
            this.lblText.Text = "label1";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblText.Click += new System.EventHandler(this.WindowTab_Click);
            this.lblText.MouseEnter += new System.EventHandler(this.WindowTab_MouseEnter);
            this.lblText.MouseLeave += new System.EventHandler(this.WindowTab_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::SoftwareTrainingApplication.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(126, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.WindowTab_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.WindowTab_MouseLeave);
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pctLogo.Image = global::SoftwareTrainingApplication.Properties.Resources.Code;
            this.pctLogo.Location = new System.Drawing.Point(0, 0);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(30, 30);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 4;
            this.pctLogo.TabStop = false;
            this.pctLogo.Click += new System.EventHandler(this.WindowTab_Click);
            this.pctLogo.MouseEnter += new System.EventHandler(this.WindowTab_MouseEnter);
            this.pctLogo.MouseLeave += new System.EventHandler(this.WindowTab_MouseLeave);
            // 
            // WindowTab
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel);
            this.Name = "WindowTab";
            this.Size = new System.Drawing.Size(150, 30);
            this.Click += new System.EventHandler(this.WindowTab_Click);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Tools.CustomPanel panel;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pctLogo;
    }
}
