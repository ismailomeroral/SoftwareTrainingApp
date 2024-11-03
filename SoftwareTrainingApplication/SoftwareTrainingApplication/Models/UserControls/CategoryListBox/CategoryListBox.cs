using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.Models.UserControls.CategoryListBox
{
    public partial class CategoryListBox : UserControl
    {


        public CategoryListBox()
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

        CategoryListItem main = new CategoryListItem("*");
        /// <summary>
        /// İç  kategorilerden istediğinize eklemek için örnekteki gibi yolu belirtin.
        /// örnek: "*/Döngüler/For"
        /// </summary>
        /// <param name="_text"></param>
        /// <param name="path"></param>
        public void Add(string _text, string path)
        {
            main.AddCategoryByPath(_text, path);
            pnlBody.Controls.Clear();
            ControlToList(pnlBody, main, 0, 0);
        }

        public void ControlToList(Panel _mainPanel, CategoryListItem _item, int _categoryIndex, int _lastY)
        {
            _item.Location = new Point(5 , 10 +_item.Height);
            _item.Size = new Size(_mainPanel.Width   , _item.Height );
            _mainPanel.Controls.Add(_item);
            _lastY = _item.Location.Y;
            MessageBox.Show(_item.Texts+" Boyutları:(w:" + _item.Width + " h:" + _item.Height + ") ; "+_item.Texts + " Konumu:(x:" + _item.Location.X + " y:" + _item.Location.Y + ") ;");

            foreach (var item in _item.subItems)
            {
                item.Location = new Point(5, 10 );
                _mainPanel.Controls.Add(item);
                item.Size = new Size(_mainPanel.Width , _item.Height);
                MessageBox.Show(item.Texts + " Boyutları:(w:" + item.Width + " h:" + item.Height + ") ; "+ item.Texts + " Konumu:(x:" + item.Location.X + " y:" + item.Location.Y + ") ;");
                _lastY = item.Location.Y;
            }
            foreach (var item in _item.subCategories)
            {
                ControlToList(_mainPanel, item, _categoryIndex + 1, _lastY);
            }

        }
    }
}
