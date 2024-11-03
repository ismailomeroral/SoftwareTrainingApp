namespace SoftwareTrainingApplication.Models.Forms.AIWindows
{
    partial class frmAppGen
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerateApp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprompt = new System.Windows.Forms.TextBox();
            this.cmboxdetail = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Prompt";
            // 
            // btnGenerateApp
            // 
            this.btnGenerateApp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnGenerateApp.ForeColor = System.Drawing.Color.White;
            this.btnGenerateApp.Location = new System.Drawing.Point(12, 625);
            this.btnGenerateApp.Name = "btnGenerateApp";
            this.btnGenerateApp.Size = new System.Drawing.Size(326, 46);
            this.btnGenerateApp.TabIndex = 16;
            this.btnGenerateApp.Text = "Create With AI";
            this.btnGenerateApp.UseVisualStyleBackColor = false;
            this.btnGenerateApp.Click += new System.EventHandler(this.btnGenerateApp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Detail Level";
            // 
            // txtprompt
            // 
            this.txtprompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtprompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtprompt.ForeColor = System.Drawing.Color.White;
            this.txtprompt.Location = new System.Drawing.Point(12, 46);
            this.txtprompt.Multiline = true;
            this.txtprompt.Name = "txtprompt";
            this.txtprompt.Size = new System.Drawing.Size(326, 488);
            this.txtprompt.TabIndex = 17;
            // 
            // cmboxdetail
            // 
            this.cmboxdetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboxdetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmboxdetail.ForeColor = System.Drawing.Color.White;
            this.cmboxdetail.FormattingEnabled = true;
            this.cmboxdetail.Items.AddRange(new object[] {
            "Basit",
            "Normal",
            "Detaycı",
            "Profesyonel"});
            this.cmboxdetail.Location = new System.Drawing.Point(120, 556);
            this.cmboxdetail.Name = "cmboxdetail";
            this.cmboxdetail.Size = new System.Drawing.Size(218, 32);
            this.cmboxdetail.TabIndex = 14;
            this.cmboxdetail.Text = "Basit";
            // 
            // frmAppGen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(350, 683);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGenerateApp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtprompt);
            this.Controls.Add(this.cmboxdetail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAppGen";
            this.Text = "AppGen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerateApp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprompt;
        private System.Windows.Forms.ComboBox cmboxdetail;
    }
}