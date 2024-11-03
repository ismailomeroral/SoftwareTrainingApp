using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.Models.UserControls
{
    public partial class CheckListBox : UserControl
    {
        private List<CheckListItem> Items = new List<CheckListItem>();
        public CheckListBox()
        {
            InitializeComponent();
        }
        bool titleCheck => Title != "";
        [Category("Appearance")]
        public string Title
        {
            get { return txtTitle.Text; }
            set { txtTitle.Text = value; }
        }

        [Category("Appearance")]
        public bool AllCheckItem
        {
            get;
            set;
        }
        private Color itemBackColor;
        [Category("Appearance")]
        public Color ItemsBackColor { get { return itemBackColor; } set { Items.ForEach(b => b.BackColor = value); itemBackColor = value; } }
        private Color itemCheckedColor;

        [Category("Appearance")]
        public Color CheckedColor { get { return itemCheckedColor; } set { Items.ForEach(b => b.CheckedColor = value); itemCheckedColor = value; } }
        private void ControlToList()
        {
            pnlBody.Controls.Clear();
            pnlTitle.Visible = titleCheck;
            int i = 0;
            foreach (var item in Items)
            {
                item.Location = new Point(5, (i * item.Height) + 10);
                pnlBody.Controls.Add(item);
                item.Check();
                item.BackColor = itemBackColor;
                item.Size = new Size(item.Parent.Width - 10, item.Height);
                i++;
            }
        }
        public void Add(string _text, bool _checked)
        {
            Items.Add(new CheckListItem { Texts = _text, Checked = _checked });
            ControlToList();
        }
        public void Add(string _text)
        {
            Items.Add(new CheckListItem { Texts = _text, Checked = false });
            ControlToList();
        }
        public void Remove(string _text)
        {
            Items.Remove(Items.Where(b => b.Texts == _text).First());
            ControlToList();
        }
        public void Remove(int _index)
        {
            Items.RemoveAt(_index);
            ControlToList();
        }
        public void Remove(bool _checked)
        {
            foreach (var item in Items.Where(b => b.Checked == _checked))
            {
                Items.Remove(item);
            }
            ControlToList();
        }
        public List<string> CheckedItemToList()
        {
            List<string> list = new List<string>();
            foreach (var item in Items.Where(b => b.Checked).ToList())
            {
                list.Add(item.Texts);
            }
            return list;
        }
        public List<string> UncheckedItemToList()
        {
            List<string> list = new List<string>();
            foreach (var item in Items.Where(b => !b.Checked).ToList())
            {
                list.Add(item.Texts);
            }
            return list;
        }
        public List<CheckListItem> ToList()
        {
            return Items;
        }



    }

}
