using Newtonsoft.Json.Linq;
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

namespace SoftwareTrainingApplication.Models.UserControls.DocumentFormatTextBox
{
    internal partial class DocumentFormatTextBox : UserControl
    {

        public DocumentFormatTextBox()
        {
            InitializeComponent();
        }
        private List<Chat> SplitText(string _text)
        {
            return TextController.SplitTextIntoCodeAndMessage(_text);
        }

        [Category("Behavior")]
        public string Title { get { return lbltitle.Text; } set { lbltitle.Text = value; } }
        [Category("Behavior")]
        public bool isTitle { get { return pnlTitle.Visible; } set { pnlTitle.Visible = value; } }


        public void AddDocuments(List<Chat> _list, string _title)
        {
            Title = _title;
            foreach (var item in _list)
            {
                if (item.user == "code")
                    AddCodeBlockToPanel(item.message);
                else if (item.user == "text")
                    AddTextBlockToPanel(item.message);
            }
        }
        private void AddCodeBlockToPanel(string _text)
        {
            CodePanel pnl = new CodePanel();
            pnl.SetText(_text);
            pnl.ReadOnly = true;
            pnl.IsResizeByLines = true;
            pnl.FixItButton = false;
            pnl.AskButton = false;
            pnlMain.Controls.Add(pnl);
            pnl.Width = pnlMain.Width - (15 * 2);

        }
        private void AddTextBlockToPanel(string _text)
        {
            TextPanel pnl = new TextPanel();
            pnl.ReadOnly = true;
            pnlMain.Controls.Add(pnl);
            pnl.SetText(_text);
            pnl.Width = pnlMain.Width - (15 * 2);
        }
        private void DocumentFormatTextBox_SizeChanged(object sender, EventArgs e)
        {
            int newHeight = 0;
            for (int i = 0; i < pnlMain.Controls.Count; i++)
            {
                pnlMain.Controls[i].Width = pnlMain.Width - 30;
                newHeight += pnlMain.Controls[i].Height;
            }
            this.Height = newHeight +30;
        }

    }
}
