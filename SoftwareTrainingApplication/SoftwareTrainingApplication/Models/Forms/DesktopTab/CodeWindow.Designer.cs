namespace SoftwareTrainingApplication.Models.Forms.DesktopTab
{
    partial class CodeWindow
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
            this.pnlCode = new SoftwareTrainingApplication.Models.UserControls.DocumentFormatTextBox.CodePanel();
            this.SuspendLayout();
            // 
            // pnlCode
            // 
            this.pnlCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCode.AskButton = true;
            this.pnlCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.pnlCode.CodeBenchButton = true;
            this.pnlCode.CopyButton = true;
            this.pnlCode.FixItButton = true;
            this.pnlCode.IsResizeByLines = false;
            this.pnlCode.Location = new System.Drawing.Point(12, 12);
            this.pnlCode.Name = "pnlCode";
            this.pnlCode.ReadOnly = false;
            this.pnlCode.RunButton = true;
            this.pnlCode.Size = new System.Drawing.Size(1264, 630);
            this.pnlCode.TabIndex = 0;
            this.pnlCode.TabJumpButton = true;
            // 
            // CodeWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1288, 654);
            this.Controls.Add(this.pnlCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CodeWindow";
            this.Text = "CodeWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.DocumentFormatTextBox.CodePanel pnlCode;
    }
}