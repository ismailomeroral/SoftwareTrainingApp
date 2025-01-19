using SoftwareTrainingApplication.Models.CodeBench.Parts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.Models.Forms.TESTS
{
    internal partial class BenchTest : Form
    {
        public BenchTest()
        {
            InitializeComponent();
            valueblock = new ValuePart
            {
                Color = Color.Brown,
                Location = (100,100),
                Size = (60,30),
                value = "Deneme",
                info = "variable",
                name = "",
                insidePart = new ValuePart
                {
                    Color = Color.Red,
                    Location = (100, 100),
                    Size = (60, 30),
                    value = "selam",
                    info = "variable",
                    name = "Değişken",
                }
            };
            valueblock1 = new ValuePart
            {
                Color = Color.Brown,
                Location = (200, 100),
                Size = (60, 30),
                value = "Deneme",
                info = "variable",
                name = "",
              
            };
            this.DoubleBuffered = true;
            this.MouseDown += (s, e) => valueblock.OnMouseDown(e);
            this.MouseMove += (s, e) => valueblock.OnMouseMove(e,this);
            this.MouseUp += (s, e) => valueblock.OnMouseUp(e);
            this.MouseDoubleClick += (s, e) => valueblock.OnClick(e, this);

            this.MouseDown += (s, e) => valueblock1.OnMouseDown(e);
            this.MouseMove += (s, e) => valueblock1.OnMouseMove(e, this);
            this.MouseUp += (s, e) => valueblock1.OnMouseUp(e);
            this.MouseDoubleClick += (s,e) => valueblock1.OnClick(e, this);
        }
        public ValuePart valueblock ;
        public ValuePart valueblock1;
        private void BenchTest_Paint(object sender, PaintEventArgs e)
        {
            valueblock.OnPaint( e);
            valueblock1.OnPaint( e);
        }
      
    }
}
