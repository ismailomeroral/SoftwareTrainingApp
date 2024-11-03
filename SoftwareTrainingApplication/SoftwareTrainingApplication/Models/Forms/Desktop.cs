using SoftwareTrainingApplication.Models.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.Models.Forms
{
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
        }
        public int TabCount
        {
            get
            {
                return pnlTabs.Controls.Count;
            }
        }
        public WindowTab OpeningWindow { get; private set; }
        public List<WindowTab> Tabs { get; private set; } = new List<WindowTab>();
        private void AddTabsToPanel()
        {
            pnlTabs.Controls.Clear();
            Tabs.ForEach(tab => pnlTabs.Controls.Add(tab));
            if (Tabs.Count > 1)
                TabsResize();
        }
        public void AddTab(WindowTab _tab)
        {
            Tabs.Add(_tab);
            if (TabCount < 1)
                OpenWindow(Tabs.First());

            AddTabsToPanel();
        }
        public void OpenWindow(WindowTab _tab)
        {
            pnlMain.Controls.Clear();
            OpeningWindow = _tab;
            if (_tab != null)
            {
                _tab.Window.TopLevel = false;
                _tab.Window.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(_tab.Window);
                _tab.Window.Show();
                SelectOpeningWindow();
            }

        }
        private void SelectOpeningWindow()
        {
            Tabs.ForEach(tab => tab.isSelectedTab = false);
            OpeningWindow.isSelectedTab = true;
        }
        public void CloseTab(WindowTab _Tab)
        {
            SelectOpeningWindow();
            Tabs.Remove(_Tab);
            AddTabsToPanel();
            if (OpeningWindow == _Tab)
            {
                if (Tabs.Count < 1)
                    OpenWindow(null);
                else
                    OpenWindow(Tabs.First());
            }
        }

        private void TabsResize()
        {
            int totalWidth = pnlTabs.Controls.Cast<Control>().Sum(tab => tab.Width);
            int currentTabWidth = (pnlTabs.Width - 55) / pnlTabs.Controls.Count;
            currentTabWidth = (currentTabWidth > 150) ? 150 : (currentTabWidth < 30) ? 30 : currentTabWidth;
            foreach (Control item in pnlTabs.Controls)
                item.Width = currentTabWidth;
        }
        private void Desktop_SizeChanged(object sender, EventArgs e)
        {
            if (TabCount > 1)
                TabsResize();
        }
    }
}
