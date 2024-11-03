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
    public partial class CheckListItem : UserControl
    {

        [Category("Appearance")]
        public bool Checked { get; set; }
        [Category("Appearance")]
        public Color CheckedColor { get; set; } = Color.Black;
        [Category("Appearance")]
        public Color UncheckedColor { get; set; } = Color.White;
        [Category("Appearance")]
        public string Texts { get => text.Text; set => text.Text = value; }
        public CheckListItem()
        {
            InitializeComponent();
        }
        public void Check()
        {
            checkbox.BackColor = (Checked ? CheckedColor : UncheckedColor);
        }

        private void CheckListItem_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
            Check();
        }
    }
}
