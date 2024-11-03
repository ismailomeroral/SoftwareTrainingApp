namespace SoftwareTrainingApplication.Models.Forms.DesktopTab
{
    partial class AIChatWindow
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
            this.pnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaveChat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.AutoScroll = true;
            this.pnlMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlMain.Location = new System.Drawing.Point(12, 42);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1264, 600);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.WrapContents = false;
            // 
            // btnSaveChat
            // 
            this.btnSaveChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnSaveChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChat.ForeColor = System.Drawing.Color.White;
            this.btnSaveChat.Location = new System.Drawing.Point(1166, 5);
            this.btnSaveChat.Name = "btnSaveChat";
            this.btnSaveChat.Size = new System.Drawing.Size(110, 31);
            this.btnSaveChat.TabIndex = 2;
            this.btnSaveChat.Text = "Save Chat";
            this.btnSaveChat.UseVisualStyleBackColor = false;
            this.btnSaveChat.Click += new System.EventHandler(this.btnSaveChat_Click);
            // 
            // AIChatWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1288, 654);
            this.Controls.Add(this.btnSaveChat);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AIChatWindow";
            this.Text = "AIChatWindow";
            this.SizeChanged += new System.EventHandler(this.AIChatWindow_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlMain;
        private System.Windows.Forms.Button btnSaveChat;
    }
}