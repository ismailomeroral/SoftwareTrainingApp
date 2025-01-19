using SoftwareTrainingApplication.Models.Forms;
using SoftwareTrainingApplication.Models.Forms.DesktopTab;
using SoftwareTrainingApplication.Models.Tools;
using SoftwareTrainingApplication.Models.UserControls;
using SoftwareTrainingApplication.Properties;
using SoftwareTrainingApplication.ViewModels;
using SoftwareTrainingApplication.ViewModels.Style;
using SoftwareTrainingApplication.ViewModels.Style_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication
{
    partial class frmMain : CustomForm
    {
        AIWindow aiWindow;
        Desktop desktopWindow;
        public frmMain()
        {
            InitializeComponent();
            FormMovedEvent fME = new FormMovedEvent();

            desktopWindow = new Desktop();
            aiWindow = new AIWindow(desktopWindow);

            btnCloseApp.MouseEnter += StyleEvents.Object_MouseEnter;
            btnMax.MouseEnter += StyleEvents.Object_MouseEnter;
            btnMin.MouseEnter += StyleEvents.Object_MouseEnter;

            btnCloseApp.MouseHover += StyleEvents.Object_MouseLeave;
            btnMax.MouseLeave += StyleEvents.Object_MouseLeave;
            btnMin.MouseLeave += StyleEvents.Object_MouseLeave;


            OpenWindow(aiWindow, pnlAIWindow);
            OpenWindow(desktopWindow, pnlDesktopWindow);

            fME.SetForm(this, pnlBar);

            desktopWindow.AddCodeTab("Yeni Code Penceresi");
        }
        private void AllWindowOpen()
        {
            aiWindow.TopLevel = false;
            aiWindow.Dock = DockStyle.Fill;
            pnlAIWindow.Controls.Add(aiWindow);
            aiWindow.Show();
        }
        private void OpenWindow(Form _frm, Panel _control)
        {
            _frm.TopLevel = false;
            _frm.Dock = DockStyle.Fill;
            _control.Controls.Add(_frm);
            _frm.Show();
        }


        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                btnMax.Image = Resources.Maximize;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                btnMax.Image = Resources.Normalize;
            }
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void codeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desktopWindow.AddCodeTab("Code");
        }
        private void codeBenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desktopWindow.AddCodeBenchTab("Code Bench");
        }
    }
}
