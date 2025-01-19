using SoftwareTrainingApplication.EntityModels;
using SoftwareTrainingApplication.Models.Forms.DesktopTab;
using SoftwareTrainingApplication.Models.UserControls;
using SoftwareTrainingApplication.Properties;
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
    partial class frmSkillCheck : Form
    {
        TimeController quizTime = new TimeController();
        public frmSkillCheck( Desktop _MainDesktop)
        {
            InitializeComponent();
            desk = _MainDesktop;

            SubjectController.ToListByType("code").ForEach(subject => chlistboxSubjects.Add(subject.name));
        }

        Desktop desk;
        public void SetDesktop(Desktop _MainDesktop)
        {
            desk = _MainDesktop;
        }

        bool passedType = false;
        string questionPrompt;
        bool quizState = false;
        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            if (!ErrorController.CheckForInternetConnection())
                return;

            Cursor = Cursors.WaitCursor;
            if (!quizState)
                CreateQuizRequest();
            else
                SendYourQuizResponse();
            Cursor = Cursors.Default;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = quizTime.TimerExport();
            if (passedType)
                quizTime.timeFlowingBackward(1);
            else
                quizTime.timeFlowingForward(1);

            if (quizTime.IsFinishTime())
            {
                SendYourQuizResponse();
            }
        }
        Request thisRequest = new Request();
        WindowTab codeTab = new WindowTab();
        private void QuizMode()
        {
            btnStartQuiz.Text = (quizState ? "Start Quiz" : "Finish Quiz");
            panel1.Visible = quizState;
            quizState = !quizState;
            codeTab.CanItBeClosed = true;
        }

        private async void CreateQuizRequest()
        {
            btnStartQuiz.Enabled = false;
            quizTime.TimeSet(0, 0);
            thisRequest.id = GenerateController.GenerateRandomKey(16);
            thisRequest.title = Text;
            thisRequest.chats = AIController.ListChatHistory(Environment.UserName, Prompts.TestYourself(chlistboxSubjects.CheckedItemToList(), cmboxDifficulty.Text));
            questionPrompt = await AIController.SendRequestAndGetResponse(thisRequest.chats.First().message, 2);
            AIController.ListChatHistory(thisRequest.chats, Gemini.Name, questionPrompt);
            desk.AddChatTab(new WindowTab { Title = thisRequest.title, ID = thisRequest.id, TabImage = Resources.Chat_Message, CanItBeClosed = false, Window = new AIChatWindow { thisRequest = thisRequest } });

            CreateCodeTabForQuiz();

            passedType = (cmboxTime.Text != "limit yok");

            if (passedType)
                quizTime.TimeSet(0, Convert.ToInt32(cmboxTime.Text));
            QuizMode();
            timer.Start();
            btnStartQuiz.Enabled = true;

        }

        private void CreateCodeTabForQuiz()
        {
            codeTab = new WindowTab()
            {
                ID = GenerateController.GenerateRandomKey(5),
                Title = "For SkillCheck",
                CanItBeClosed = false,
                Window = new CodeWindow()
                {
                    AskButton = false,
                    CopyButton = true,
                    FixItButton = false,
                }
            };
            desk.AddCodeTab(codeTab);
        }
        private async void SendYourQuizResponse()
        {
            timer.Stop();

            thisRequest.chats = AIController.ListChatHistory(Environment.UserName, Prompts.ControlYourTest(questionPrompt, (codeTab.Window as CodeWindow).Texts));
            AIController.ListChatHistory(thisRequest.chats, Gemini.Name, await AIController.SendRequestAndGetResponse(thisRequest.chats.Last().message, 2));
            desk.AddToCurrentChatTab(thisRequest, true);
            QuizMode();
        }
    }
}
