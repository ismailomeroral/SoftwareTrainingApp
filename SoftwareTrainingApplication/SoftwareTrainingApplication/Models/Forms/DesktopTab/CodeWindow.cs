using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.Models.Forms.DesktopTab
{
    public partial class CodeWindow : Form
    {
        public CodeWindow()
        {
            InitializeComponent();
        }
        public string Texts { get { return pnlCode.GetText(); } set { pnlCode.SetText(value); } }

        public bool AskButton { get { return pnlCode.AskButton; } set { pnlCode.AskButton = value; } }
        public bool FixItButton { get { return pnlCode.FixItButton; } set { pnlCode.FixItButton = value; } }
        public bool CopyButton { get { return pnlCode.CopyButton; } set { pnlCode.CopyButton = value; } }
        public bool CodeBenchButton { get { return pnlCode.CodeBenchButton; } set { pnlCode.AskButton = CodeBenchButton; } }

    }
}
