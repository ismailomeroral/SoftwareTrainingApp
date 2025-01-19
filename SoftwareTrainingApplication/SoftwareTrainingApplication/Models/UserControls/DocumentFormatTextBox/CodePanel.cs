using SoftwareTrainingApplication.EntityModels;
using SoftwareTrainingApplication.Models.Forms;
using SoftwareTrainingApplication.Models.Forms.DesktopTab;
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
    partial class CodePanel : UserControl
    {
        public CodePanel()
        {
            InitializeComponent();

            btnCopy.Click += (s, e) => Clipboard.SetText((textbox.Text != "" ? textbox.Text : " "));
            TextController.AdjustTextBoxHeight(textbox);
        }

        Desktop desk;
        public void SetDesktop(Desktop _MainDesktop)
        {
            desk = _MainDesktop;
        }

        List<Subject> codes = new List<Subject>
        {
            new Subject{name = "string", type = "Variables"},
            new Subject{name = "int", type = "Variables"},
            new Subject{name = "int[]", type = "Variables"},
            new Subject{name = "float", type = "Variables"},
            new Subject{name = "char", type = "Variables"},
            new Subject{name = "bool", type = "Variables"},
            new Subject{name = "decimal", type = "Variables"},
            new Subject{name = "double", type = "Variables"},
            new Subject{name = "var", type = "Variables"},
            new Subject{name = "object", type = "Variables"},

            new Subject{name = "switch", type = "ControlStructures"},
            new Subject{name = "if", type = "ControlStructures"},
            new Subject{name = "else", type = "ControlStructures"},
            new Subject{name = "for", type = "ControlStructures"},
            new Subject{name = "foreach", type = "ControlStructures"},
            new Subject{name = "while", type = "ControlStructures"},
            new Subject{name = "do", type = "ControlStructures"},
            new Subject{name = "continue", type = "ControlStructures"},
            new Subject{name = "break", type = "ControlStructures"},
            new Subject{name = "try", type = "ControlStructures"},
            new Subject{name = "finally", type = "ControlStructures"},
            new Subject{name = "catch", type = "ControlStructures"},

            new Subject{name = "public", type = "Objects"},
            new Subject{name = "private", type = "Objects"},
            new Subject{name = "static", type = "Objects"},
            new Subject{name = "void", type = "Objects"},
            new Subject{name = "return", type = "Objects"},
            new Subject{name = "class", type = "Objects"},
            new Subject{name = "namespace", type = "Objects"},
            new Subject{name = "using", type = "Objects"},


            new Subject{name = "List", type = "Collections"},
            new Subject{name = "Dictionary", type = "Collections"},
            new Subject{name = "HashSet", type = "Collections"},
            new Subject{name = "Queue", type = "Collections"},
            new Subject{name = "Stack", type = "Collections"},
            new Subject{name = "ArrayList", type = "Collections"},


        };


        [Category("Behavior")]
        public bool ReadOnly { get { return textbox.ReadOnly; } set { textbox.ReadOnly = value; } }

        [Category("Buttons")]
        public bool CopyButton { get { return btnCopy.Visible; } set { btnCopy.Visible = value; } }

        [Category("Buttons")]
        public bool AskButton { get { return btnAsk.Visible; } set { btnAsk.Visible = value; } }
        [Category("Buttons")]
        public bool RunButton { get { return btnRun.Visible; } set { btnRun.Visible = value; } }
        [Category("Buttons")]
        public bool FixItButton { get { return btnFixIt.Visible; } set { btnFixIt.Visible = value; } }
        [Category("Buttons")]
        public bool CodeBenchButton { get { return btnCodeBench.Visible; } set { btnCodeBench.Visible = value; } }
        [Category("Buttons")]
        public bool TabJumpButton { get { return btnTabJump.Visible; } set { btnTabJump.Visible = value; } }
        [Category("Behavior")]
        public bool IsResizeByLines { get; set; } = false;
        public void SetText(string _text)
        {
            textbox.Text = _text;

        }
        public string GetText()
        {
            return textbox.Text;
        }

        private void ConvertTextToCodeLine(RichTextBox _txt)
        {
            // Son değişiklik yapılan pozisyon
            int changePosition = _txt.SelectionStart;

            // Değişiklik yapılan bölgeye ait satırı alın
            int lineStart = _txt.GetFirstCharIndexOfCurrentLine();
            int lineEnd = _txt.Text.IndexOf('\n', lineStart);
            lineEnd = lineEnd == -1 ? _txt.Text.Length : lineEnd;

            // Sadece bu satır üzerinde işlem yap
            string lineText = _txt.Text.Substring(lineStart, lineEnd - lineStart);

            // Önce bu satırdaki renklendirmeyi sıfırla
            _txt.Select(lineStart, lineText.Length);
            _txt.SelectionColor = Color.White;

            // Kelimeleri renklendir
            foreach (var item in codes.Where(b => b.type == "Variables"))
            {
                // Bu satırda, değişken ismi bulunuyorsa renklendir
                var variables = TextController.FindWordPositions(lineText, item.name);
                foreach (var variable in variables)
                {
                    int startVName = lineStart + variable + item.name.Length;
                    try
                    {
                        // Değişkenin solundaki karakter
                        bool leftValid = variable == 0 || char.IsWhiteSpace(_txt.Text[lineStart + variable - 1]) ||
                                         "(){}[],.;".Contains(_txt.Text[lineStart + variable - 1]);

                        // Değişkenin sağındaki karakter
                        bool rightValid = startVName >= _txt.Text.Length ||
                                          char.IsWhiteSpace(_txt.Text[startVName]) ||
                                          "(){}[],.;".Contains(_txt.Text[startVName]);

                        // Sadece sol ve sağ geçerli karakterlerle çevrelenmişse renklendir
                        if (leftValid && rightValid)
                        {
                            // Değişken ismini renklendir
                            _txt.Select(lineStart + variable, item.name.Length);
                            _txt.SelectionColor = Color.Blue;

                            // Sonraki kelimeyi kontrol et ve özel karakterlerle sınırla
                            var variablenames = _txt.Text.Substring(startVName + 1).Split(' ', ')', '(', ';', ',', '[', ']', '{', '}')[0];
                            if (variablenames != null)
                            {
                                _txt.Select(startVName + 1, variablenames.Length);
                                _txt.SelectionColor = Color.FromArgb(255, 74, 144, 226);
                            }
                        }
                    }
                    catch { }
                }

            }
            foreach (var item in codes.Where(b => b.type == "ControlStructures"))
            {
                // Bu satırda, değişken ismi bulunuyorsa renklendir
                var controlStructures = TextController.FindWordPositions(lineText, item.name);
                foreach (var controls in controlStructures)
                {
                    int startVName = lineStart + controls + item.name.Length;
                    // Değişkenin solundaki karakter
                    bool leftValid = controls == 0 || char.IsWhiteSpace(_txt.Text[lineStart + controls - 1]) ||
                                     "(){}[],.;".Contains(_txt.Text[lineStart + controls - 1]);

                    // Değişkenin sağındaki karakter
                    bool rightValid = startVName >= _txt.Text.Length ||
                                      char.IsWhiteSpace(_txt.Text[startVName]) ||
                                      "(){}[],.;".Contains(_txt.Text[startVName]);
                    if (leftValid && rightValid)
                    {
                        // Değişken ismini renklendir
                        _txt.Select(lineStart + controls, item.name.Length);
                        _txt.SelectionColor = Color.FromArgb(255, 0, 172, 193);
                    }
                }

            }

            // Değişiklik sonrası imleci geri yükle
            _txt.Select(changePosition, 0);
            _txt.SelectionColor = Color.White;

        }
        private void textbox_TextChanged(object sender, EventArgs e)
        {
            if (IsResizeByLines)
                TextController.AdjustTextBoxHeight(textbox);
            //ConvertTextToCodeLine(textbox);
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            if (!ErrorController.CheckForInternetConnection())
                return;
            List<Chat> chat = AIController.ListChatHistory(Environment.UserName, Prompts.CodeRun(null, textbox.Text));
            AIController.ListChatHistory(chat, Gemini.Name, await AIController.SendRequestAndGetResponse(chat.First().message, 2));

            desk.AddChatTab(new Request { id = "", title = Text, chats = chat });

        }
        private async void btnFixIt_Click(object sender, EventArgs e)
        {
            if (!ErrorController.CheckForInternetConnection())
                return;

            List<Chat> chat = AIController.ListChatHistory(Environment.UserName, Prompts.CodeFixIt(textbox.Text));
            AIController.ListChatHistory(chat, Gemini.Name, await AIController.SendRequestAndGetResponse(chat.First().message, 2));
            textbox.Text = TextController.SplitTextIntoCodeAndMessage(chat.Where(b => b.user == Gemini.Name).First().message)
                                                                           .Where(b => b.user == "code").First().message;

            desk.AddChatTab(new Request { id = "", title = Text, chats = chat });
        }

        private async void btnAsk_Click(object sender, EventArgs e)
        {
            if (!ErrorController.CheckForInternetConnection())
                return;

            List<Chat> chat = AIController.ListChatHistory(Environment.UserName, Prompts.RequestCodeFromAI(textbox.Text));
            AIController.ListChatHistory(chat, Gemini.Name, await AIController.SendRequestAndGetResponse(chat.First().message, 2));
            textbox.Text = TextController.SplitTextIntoCodeAndMessage(chat.Where(b => b.user == Gemini.Name).First().message)
                                                                          .Where(b => b.user == "code").First().message;

            desk.AddChatTab(new Request { id = "", title = Text, chats = chat });
        }

        private void btnCodeBench_Click(object sender, EventArgs e)
        {
            desk.AddCodeTab(new WindowTab() { ID = GenerateController.GenerateRandomKey(5), Window = new CodeBenchWindow() });
        }
        private void btnTabJump_Click(object sender, EventArgs e)
        {
            desk.AddCodeTab(new WindowTab() { ID = GenerateController.GenerateRandomKey(5), Window = new CodeWindow() { Texts = textbox.Text } });
        }
    }
}
