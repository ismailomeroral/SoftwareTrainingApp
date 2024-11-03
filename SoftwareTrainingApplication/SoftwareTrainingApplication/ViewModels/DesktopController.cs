using SoftwareTrainingApplication.Models;
using SoftwareTrainingApplication.Models.Forms;
using SoftwareTrainingApplication.Models.Forms.DesktopTab;
using SoftwareTrainingApplication.Models.UserControls;
using SoftwareTrainingApplication.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.ViewModels
{
    internal class DesktopController
    {
        static public Desktop MainDesktop { get; private set; }
        public static void SetDesktop(Desktop _desktop)
        {
            MainDesktop = _desktop;
        }
        public static void AddChatTab(Request _request)
        {
            AIChatWindow chatWindow = new AIChatWindow()
            {
                thisRequest = _request,
            };
            chatWindow.SetRequest(_request);
            WindowTab tab = new WindowTab
            {
                ID = _request.id,
                Title = _request.title,
                Window = chatWindow,
                TabImage = Resources.Chat_Message
            };
            MainDesktop.AddTab(tab);
        }
        public static void AddChatTab(WindowTab _tab)
        {
            (_tab.Window as AIChatWindow).SetRequest((_tab.Window as AIChatWindow).thisRequest);
            MainDesktop.AddTab(_tab);
        }
        public static void AddToCurrentChatTab(Request _request, bool _canItBeClosed)
        {
            (MainDesktop.Tabs.Where(b => b.ID == _request.id).First().Window as AIChatWindow).SetRequest(_request);
            MainDesktop.Tabs.Where(b => b.ID == _request.id).First().CanItBeClosed = _canItBeClosed;
        }
        public static void AddCodeTab(string _title)
        {
            WindowTab tab = new WindowTab
            {
                ID = MainDesktop.TabCount + "",
                Title = _title,
                Window = new CodeWindow(),
                TabImage = Resources.Code
            };
            MainDesktop.AddTab(tab);
        }
        public static void AddCodeTab(WindowTab _tab)
        {
            MainDesktop.AddTab(_tab);
        }
        public static void AddCodeBenchTab(string _title)
        {
            WindowTab tab = new WindowTab
            {
                Title = _title,
                Window = new CodeBenchWindow(),
                TabImage = Resources.Blockly
            };
            MainDesktop.AddTab(tab);
        }


        public static void CloseTab(WindowTab _tab)
        {
            MainDesktop.CloseTab(_tab);
        }

    }
}
