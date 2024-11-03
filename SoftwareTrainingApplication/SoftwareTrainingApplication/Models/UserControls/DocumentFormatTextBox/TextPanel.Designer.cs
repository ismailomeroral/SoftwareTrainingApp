namespace SoftwareTrainingApplication.Models.UserControls.DocumentFormatTextBox
{
    partial class TextPanel
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
            this.textbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox.ForeColor = System.Drawing.Color.White;
            this.textbox.Location = new System.Drawing.Point(3, 3);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(433, 266);
            this.textbox.TabIndex = 3;
            this.textbox.Text = "";
            this.textbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // TextPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.textbox);
            this.Name = "TextPanel";
            this.Size = new System.Drawing.Size(439, 272);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox textbox;
    }
}
