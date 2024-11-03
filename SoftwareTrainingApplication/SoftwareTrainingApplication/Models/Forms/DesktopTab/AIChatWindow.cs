using SoftwareTrainingApplication.Models.UserControls.DocumentFormatTextBox;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwareTrainingApplication.Models.Forms.DesktopTab
{
    internal partial class AIChatWindow : Form
    {
        public AIChatWindow()
        {
            InitializeComponent();
        }
        public Request thisRequest { get; set; }

        public void SetRequest(Request _request)
        {
            thisRequest = _request;
            SetChat(_request.chats);
        }
        private void SetChat(List<Chat> _chats)
        {
            foreach (Chat chat in _chats)
            {
                DocumentFormatTextBox dftxt = new DocumentFormatTextBox();
                dftxt.AddDocuments(TextController.SplitTextIntoCodeAndMessage(chat.message), chat.user);
                dftxt.BackColor = Color.FromArgb(70,65,65);
                dftxt.ForeColor = Color.White;
                pnlMain.Controls.Add(dftxt);
                dftxt.Width = pnlMain.Width - 30;
                dftxt.isTitle = true;
            }
        }

        private void AIChatWindow_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control item in pnlMain.Controls)
            {
                item.Width = pnlMain.Width - 30;
            }
        }

        private void btnSaveChat_Click(object sender, EventArgs e)
        {
            if (RequestDBController.FindRequest(thisRequest.id) != null)
                RequestDBController.UpdateRequest(thisRequest);
            else
                RequestDBController.AddRequest(thisRequest);

        }
    }
}
