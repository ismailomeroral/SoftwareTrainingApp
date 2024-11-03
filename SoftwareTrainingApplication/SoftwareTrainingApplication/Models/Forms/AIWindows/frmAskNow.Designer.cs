namespace SoftwareTrainingApplication.Models.Forms.AIWindows
{
    partial class frmAskNow
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmboxlearnLevel = new System.Windows.Forms.ComboBox();
            this.listboxSubjects = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Programing Subjects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Narrative Language";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(12, 625);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(326, 46);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Ask a Question";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmboxlearnLevel
            // 
            this.cmboxlearnLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboxlearnLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmboxlearnLevel.ForeColor = System.Drawing.Color.White;
            this.cmboxlearnLevel.FormattingEnabled = true;
            this.cmboxlearnLevel.Items.AddRange(new object[] {
            "giriş",
            "fikri olan",
            "bilgili birisi",
            "ileri",
            "profesyonel"});
            this.cmboxlearnLevel.Location = new System.Drawing.Point(12, 46);
            this.cmboxlearnLevel.Name = "cmboxlearnLevel";
            this.cmboxlearnLevel.Size = new System.Drawing.Size(326, 32);
            this.cmboxlearnLevel.TabIndex = 13;
            this.cmboxlearnLevel.Text = "giriş";
            // 
            // listboxSubjects
            // 
            this.listboxSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listboxSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listboxSubjects.ForeColor = System.Drawing.Color.White;
            this.listboxSubjects.FormattingEnabled = true;
            this.listboxSubjects.ItemHeight = 24;
            this.listboxSubjects.Items.AddRange(new object[] {
            "Programlama",
            "Algoritma",
            "C#",
            "Ide",
            "Nasıl kod yazabilirim",
            "Değişkenler",
            "Değişkenler - int",
            "Değişkenler - string",
            "Değişkenler - bool",
            "Değişkenler - double",
            "Değişkenler - char",
            "Değişkenler - var",
            "Değişkenler - decimal",
            "Diziler",
            "Diziler - int[]",
            "Diziler - strin[]",
            "Diziler - double[]",
            "Diziler - List<T>",
            "Diziler - Dictionary<TKey, TValue>",
            "Diziler - ArrayList",
            "Diziler - Queue"});
            this.listboxSubjects.Location = new System.Drawing.Point(12, 124);
            this.listboxSubjects.Name = "listboxSubjects";
            this.listboxSubjects.Size = new System.Drawing.Size(326, 460);
            this.listboxSubjects.TabIndex = 12;
            // 
            // frmAskNow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(350, 683);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmboxlearnLevel);
            this.Controls.Add(this.listboxSubjects);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAskNow";
            this.Text = "AskNow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmboxlearnLevel;
        private System.Windows.Forms.ListBox listboxSubjects;
    }
}