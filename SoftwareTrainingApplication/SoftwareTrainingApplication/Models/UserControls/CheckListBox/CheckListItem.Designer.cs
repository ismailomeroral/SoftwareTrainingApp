namespace SoftwareTrainingApplication.Models.UserControls
{
    partial class CheckListItem
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
            this.checkbox = new System.Windows.Forms.PictureBox();
            this.text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox)).BeginInit();
            this.SuspendLayout();
            // 
            // checkbox
            // 
            this.checkbox.BackColor = System.Drawing.Color.White;
            this.checkbox.Location = new System.Drawing.Point(3, 3);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(32, 32);
            this.checkbox.TabIndex = 0;
            this.checkbox.TabStop = false;
            this.checkbox.Click += new System.EventHandler(this.CheckListItem_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(41, 7);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(45, 24);
            this.text.TabIndex = 1;
            this.text.Text = "Item";
            this.text.Click += new System.EventHandler(this.CheckListItem_Click);
            // 
            // CheckListItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.text);
            this.Controls.Add(this.checkbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CheckListItem";
            this.Size = new System.Drawing.Size(275, 38);
            this.Click += new System.EventHandler(this.CheckListItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.checkbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox checkbox;
        private System.Windows.Forms.Label text;
    }
}
