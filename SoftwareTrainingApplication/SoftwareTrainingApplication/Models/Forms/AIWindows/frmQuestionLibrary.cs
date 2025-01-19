using SoftwareTrainingApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.Models.Forms.AIWindows
{
    partial class frmQuestionLibrary : Form
    {
        Desktop desk;
        public frmQuestionLibrary(Desktop _MainDesktop)
        {
            InitializeComponent();
            desk = _MainDesktop;
            foreach (var item in RequestDBController.ToList())
                listboxMyLibrary.Items.Add(item.id);
        }
        public void SetDesktop(Desktop _MainDesktop)
        {
            desk = _MainDesktop;
        }
        private void btnShowChat_Click(object sender, EventArgs e)
        {
            desk.AddChatTab(RequestDBController.FindRequest(listboxMyLibrary.Text));
        }
    }
}
