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
using static System.Net.Mime.MediaTypeNames;

namespace SoftwareTrainingApplication.Models.UserControls.DocumentFormatTextBox
{
    public partial class TextPanel : UserControl
    {
        public TextPanel()
        {
            InitializeComponent();
        }
        public bool ReadOnly { get { return textbox.ReadOnly; } set { textbox.ReadOnly = value; } }
        public void SetText(string _text)
        {
            textbox.Text = _text.Trim();
            TextController.AdjustTextBoxHeight(textbox);
            FormatText(textbox);
        }
        public string GetText()
        {
            return textbox.Text;
        }
        private void FormatText(RichTextBox _txt)
        {
            var formatedText =TextController.RemoveMarksAndFindLocations(_txt.Text, "**", "**", "bold");
            formatedText = TextController.RemoveMarksAndFindLocations(formatedText.text, "`", "`", "box", formatedText.locations);
            formatedText = TextController.RemoveMarksAndFindLocations(formatedText.text, "###", "\n", "nTitle", formatedText.locations);
            formatedText = TextController.RemoveMarksAndFindLocations(formatedText.text, "##", "\n", "bTitle", formatedText.locations);
            formatedText = TextController.RemoveMarksAndFindLocations(formatedText.text, "_", "_", "italic", formatedText.locations);

            _txt.Text = formatedText.text;

            foreach (var (start, length, process) in formatedText.locations)
            {
                _txt.Select(start, length);

                if (process == "bold")
                {
                    _txt.SelectionFont = new Font(_txt.Font, FontStyle.Bold);
                }
                else if (process == "box")
                {
                    _txt.SelectionBackColor = Color.FromArgb(95, 90, 90);
                }
                else if (process == "nTitle")
                {
                    _txt.SelectionFont = new Font(_txt.Font.FontFamily, _txt.Font.Size * 1.3f, FontStyle.Bold);
                }
                else if (process == "bTitle")
                {
                    _txt.SelectionFont = new Font(_txt.Font.FontFamily, _txt.Font.Size * 1.6f, FontStyle.Bold);
                }
                else if (process == "italic")
                {
                    _txt.SelectionFont = new Font(_txt.Font, FontStyle.Italic);
                }
            }
            _txt.Select(0, 0); // Seçimi temizle
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            TextController.AdjustTextBoxHeight(textbox);
        }
    }
}
