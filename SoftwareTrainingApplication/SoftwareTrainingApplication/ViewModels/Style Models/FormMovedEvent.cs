using SoftwareTrainingApplication.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.ViewModels.Style
{
    internal class FormMovedEvent
    {
        int mow, mowY, mowX;
        private CustomForm frm;

        public void SetForm(CustomForm _frm, Panel selectPanel)
        {
            frm = _frm;
            selectPanel.MouseMove += MovedForm_Move;
            selectPanel.MouseDown += MovedForm_Down;
            selectPanel.MouseUp += MovedForm_Up;
        }

        private void MovedForm_Move(object sender, MouseEventArgs e)
        {
            if (mow == 1)
            {
                if(frm.WindowState == FormWindowState.Maximized)
                    frm.WindowState = FormWindowState.Normal;
                frm.SetDesktop(mowX, mowY);
            }
        }

        private void MovedForm_Down(object sender, MouseEventArgs e)
        {
            mow = 1;
            mowX = e.X;
            mowY = e.Y;
        }

        private void MovedForm_Up(object sender, MouseEventArgs e)
        {
            mow = 0;
        }

    }
}
