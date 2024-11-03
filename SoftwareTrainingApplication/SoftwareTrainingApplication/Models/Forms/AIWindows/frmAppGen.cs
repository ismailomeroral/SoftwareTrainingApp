using SoftwareTrainingApplication.EntityModels;
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
    public partial class frmAppGen : Form
    {
        public frmAppGen()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        private async void btnGenerateApp_Click(object sender, EventArgs e)
        {
            if (!ErrorController.CheckForInternetConnection())
                return;


            List<Chat> chat = AIController.ListChatHistory(Environment.UserName, Prompts.CreateApplication(txtprompt.Text, cmboxdetail.Text));

            AIController.ListChatHistory(chat, Gemini.Name, await AIController.SendRequestAndGetResponse(chat.First().message, 2));
            DesktopController.AddChatTab(new Request { id = "", title = Text, chats = chat });
        }
    }
}
