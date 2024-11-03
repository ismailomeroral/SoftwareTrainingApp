namespace SoftwareTrainingApplication.Models.UserControls.CategoryListBox
{
    partial class CategoryListItem
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
            this.text = new System.Windows.Forms.Label();
            this.pctCategory = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.text.Location = new System.Drawing.Point(38, 7);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(52, 24);
            this.text.TabIndex = 0;
            this.text.Text = "item";
            // 
            // pctCategory
            // 
            this.pctCategory.Image = global::SoftwareTrainingApplication.Properties.Resources.Right_Button;
            this.pctCategory.Location = new System.Drawing.Point(0, 0);
            this.pctCategory.Name = "pctCategory";
            this.pctCategory.Size = new System.Drawing.Size(32, 38);
            this.pctCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCategory.TabIndex = 1;
            this.pctCategory.TabStop = false;
            // 
            // CategoryListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.pctCategory);
            this.Controls.Add(this.text);
            this.Name = "CategoryListItem";
            this.Size = new System.Drawing.Size(270, 38);
            ((System.ComponentModel.ISupportInitialize)(this.pctCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.PictureBox pctCategory;
    }
}
