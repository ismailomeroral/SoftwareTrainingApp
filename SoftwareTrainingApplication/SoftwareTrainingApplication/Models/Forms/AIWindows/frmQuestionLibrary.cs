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
    public partial class frmQuestionLibrary : Form
    {
        public frmQuestionLibrary()
        {
            InitializeComponent();
            foreach (var item in RequestDBController.ToList())
                listboxMyLibrary.Items.Add(item.id);
        }
        private void btnShowChat_Click(object sender, EventArgs e)
        {
            DesktopController.AddChatTab(RequestDBController.FindRequest(listboxMyLibrary.Text));
        }
    }
}
