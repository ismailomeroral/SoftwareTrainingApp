using SoftwareTrainingApplication.Models.Forms.AIWindows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.Models.Forms
{
    public partial class AIWindow : Form
    {

        frmAppGen windowAppGen = new frmAppGen();
        frmAskNow windowAskNow = new frmAskNow();
        frmSkillCheck windowSkillCheck = new frmSkillCheck();
        frmQuestionLibrary windowsLibrary = new frmQuestionLibrary();


        public AIWindow()
        {
            InitializeComponent();
            OpenWindow(windowAskNow);
        }

       
        bool IsAIWindowOpen = false;
        private void AIWindowOpenClose()
        {
            if (IsAIWindowOpen)
                this.Parent.Width = 350;
            else
                this.Parent.Width = pnlLeftAIMenu.Width;
        }
        private void btnAIwindow_Click(object sender, EventArgs e)
        {
            IsAIWindowOpen = !IsAIWindowOpen;
            AIWindowOpenClose();
        }
        private void btnShowAskNow_Click(object sender, EventArgs e)
        {
            IsAIWindowOpen = true;
            AIWindowOpenClose();
            OpenWindow(windowAskNow);
        }
        private void btnShowSkillCheck_Click(object sender, EventArgs e)
        {
            IsAIWindowOpen = true;
            AIWindowOpenClose();
            OpenWindow(windowSkillCheck);
        }

        private void btnShowAppGen_Click(object sender, EventArgs e)
        {
            IsAIWindowOpen = true;
            AIWindowOpenClose();
            OpenWindow(windowAppGen);
        }

        private void btnShowLibrary_Click(object sender, EventArgs e)
        {
            IsAIWindowOpen = true;
            AIWindowOpenClose();
            OpenWindow(windowsLibrary);
        }

        private void OpenWindow(Form frm)
        {
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            lblTitle.Text = frm.Text;
            pnlAIBody.Controls.Clear();
            pnlAIBody.Controls.Add(frm);
            frm.Show();
        }

        private void customPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
