using SoftwareTrainingApplication.Models.Forms;
using SoftwareTrainingApplication.ViewModels;
using SoftwareTrainingApplication.ViewModels.Style_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.Models.UserControls
{
    public partial class WindowTab : UserControl
    {
        public string ID { get; set; }
        public string Title { get => lblText.Text; set => lblText.Text = value; }
        public Form Window { get; set; }
        public bool CanItBeClosed { get { return btnClose.Visible; } set { btnClose.Visible = value; } }
        public Color TabColor { get { return panel.BackColor; } set { panel.BackColor = value; } }
        public bool isSelectedTab { get; set; } = false;

        public Image TabImage { get { return pctLogo.Image; } set { pctLogo.Image = value; } }
        public WindowTab()
        {
            InitializeComponent();
            btnClose.MouseEnter += StyleEvents.Object_MouseEnter;
            btnClose.MouseLeave += StyleEvents.Object_MouseLeave;
        }
        public void CloseWindow()
        {
            (this.Parent.Parent as Desktop).CloseTab(this);
        }
        private void WindowTab_Click(object sender, EventArgs e)
        {
            (this.Parent.Parent as Desktop).OpenWindow(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (CanItBeClosed)
                CloseWindow();
            else
                MessageBox.Show("Bu sekme şuanda başka sekme tarafından kullanılıyor.");
        }


        private void WindowTab_MouseEnter(object sender, EventArgs e)
        {
            if (!isSelectedTab)
                TabColor = Color.FromArgb(255, TabColor);
        }

        private void WindowTab_MouseLeave(object sender, EventArgs e)
        {
            if (!isSelectedTab)
                TabColor = Color.FromArgb(100, TabColor);
        }
    }
}
