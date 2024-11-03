namespace SoftwareTrainingApplication.Models.Forms.AIWindows
{
    partial class frmQuestionLibrary
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
            this.listboxMyLibrary = new System.Windows.Forms.ListBox();
            this.btnShowChat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxMyLibrary
            // 
            this.listboxMyLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listboxMyLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listboxMyLibrary.ForeColor = System.Drawing.Color.White;
            this.listboxMyLibrary.FormattingEnabled = true;
            this.listboxMyLibrary.ItemHeight = 24;
            this.listboxMyLibrary.Location = new System.Drawing.Point(12, 12);
            this.listboxMyLibrary.Name = "listboxMyLibrary";
            this.listboxMyLibrary.Size = new System.Drawing.Size(326, 580);
            this.listboxMyLibrary.TabIndex = 13;
            // 
            // btnShowChat
            // 
            this.btnShowChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnShowChat.ForeColor = System.Drawing.Color.White;
            this.btnShowChat.Location = new System.Drawing.Point(12, 625);
            this.btnShowChat.Name = "btnShowChat";
            this.btnShowChat.Size = new System.Drawing.Size(326, 46);
            this.btnShowChat.TabIndex = 17;
            this.btnShowChat.Text = "Show Me Chat";
            this.btnShowChat.UseVisualStyleBackColor = false;
            this.btnShowChat.Click += new System.EventHandler(this.btnShowChat_Click);
            // 
            // frmQuestionLibrary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(350, 683);
            this.Controls.Add(this.btnShowChat);
            this.Controls.Add(this.listboxMyLibrary);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuestionLibrary";
            this.Text = "Question Library";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listboxMyLibrary;
        private System.Windows.Forms.Button btnShowChat;
    }
}