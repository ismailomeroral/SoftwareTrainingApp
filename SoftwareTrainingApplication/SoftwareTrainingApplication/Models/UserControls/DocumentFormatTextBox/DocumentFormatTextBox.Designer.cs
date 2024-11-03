namespace SoftwareTrainingApplication.Models.UserControls.DocumentFormatTextBox
{
    partial class DocumentFormatTextBox
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
            this.pnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Controls.Add(this.pnlTitle);
            this.pnlMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlMain.Location = new System.Drawing.Point(3, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(444, 294);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.WrapContents = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlTitle.Controls.Add(this.lbltitle);
            this.pnlTitle.Location = new System.Drawing.Point(3, 3);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(438, 37);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.Visible = false;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbltitle.Location = new System.Drawing.Point(6, 6);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(49, 25);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Title";
            // 
            // DocumentFormatTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMain);
            this.Name = "DocumentFormatTextBox";
            this.Size = new System.Drawing.Size(450, 300);
            this.SizeChanged += new System.EventHandler(this.DocumentFormatTextBox_SizeChanged);
            this.pnlMain.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlMain;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lbltitle;
    }
}
