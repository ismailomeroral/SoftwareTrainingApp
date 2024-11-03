using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.ViewModels.Style_Models
{
    internal class StyleEvents
    {
        public static void BGColorChange(Panel panel, Color color)
        {
            panel.BackColor = color;
        }

        public static void Object_MouseEnter(object sender, EventArgs e)
        {
            ObjectSelect((sender as Control), true);
        }

        public static void Object_MouseLeave(object sender, EventArgs e)
        {
            ObjectSelect((sender as Control), false);
        }

        private static void ObjectSelect(Control control, bool activate)
        {
            if (activate)
                control.BackColor = Color.FromArgb(50, 0, 0, 0);
            else
                control.BackColor = Color.Transparent;
        }
    }
}
