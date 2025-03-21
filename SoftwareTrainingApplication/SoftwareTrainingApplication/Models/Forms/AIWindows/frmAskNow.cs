﻿using SoftwareTrainingApplication.EntityModels;
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
     partial class frmAskNow : Form
    {
        public frmAskNow(Desktop _MainDesktop)
        {
            InitializeComponent();
            desk = _MainDesktop;
            this.TopLevel = false;
            listboxSubjects.Items.Clear();
            SubjectController.ToList().ForEach(subject => listboxSubjects.Items.Add(subject.name));
        }
        Desktop desk;
        public void SetDesktop(Desktop _MainDesktop)
        {
            desk = _MainDesktop;
        }
        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ErrorController.CheckForInternetConnection())
                return;

            Cursor = Cursors.WaitCursor;
            List<Chat> chats = AIController.ListChatHistory(Environment.UserName, Prompts.HowCanILearn(listboxSubjects.Text, cmboxlearnLevel.Text));
            AIController.ListChatHistory(chats, Gemini.Name, await AIController.SendRequestAndGetResponse(chats.First().message, 2));
            desk.AddChatTab(new Request { id = "", title = Text, chats = chats });
            Cursor = Cursors.Default;
        }
    }
}
