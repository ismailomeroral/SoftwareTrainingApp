using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.Models.UserControls.CategoryListBox
{
    public partial class CategoryListItem : UserControl
    {
        public List<CategoryListItem> subCategories = new List<CategoryListItem>();
        public List<CategoryListItem> subItems = new List<CategoryListItem>();

        [Category("Appearance")]
        public string Texts { get => text.Text; set => text.Text = value; }
        public CategoryListItem(string text)
        {
            InitializeComponent();
            Texts = text;
        }


        public void AddSubItems(CategoryListItem _item)
        {
            subItems.Add(_item);
        }
        public void AddSubCategory(CategoryListItem _item)
        {
            subCategories.Add(_item);
        }
        public void AddCategoryByPath(string _text, string path)
        {
            string[] pathseies = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            CategoryListItem targetCategory = this;  // Başlangıçta ana klasör

            foreach (var parça in pathseies)
            {
                CategoryListItem subCategory = targetCategory.subCategories.Find(k => k.Texts == parça);

                // Eğer alt klasör mevcut değilse, oluştur
                if (subCategory == null)
                {
                    subCategory = new CategoryListItem(_text);
                    targetCategory.AddSubCategory(subCategory);
                }

                // Hedef klasörü alt klasör olarak ayarla
                targetCategory = subCategory;
            }
            // Dosyayı hedef klasöre ekle
            targetCategory.AddSubItems(new CategoryListItem(_text));

        }



     

    }
}
