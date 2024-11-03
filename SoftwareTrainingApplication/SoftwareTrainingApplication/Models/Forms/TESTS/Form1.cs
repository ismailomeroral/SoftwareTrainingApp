using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.Models.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseUp += Form1_MouseUp;
        }
        private bool isDragging = false;
        private Point startPoint;
        private int offsetX = 50; // Başlangıç x koordinatı
        private int offsetY = 50; // Başlangıç y koordinatı
        private int width = 300;
        private int height = 100;
        private int tabSize = 20;
            int cornerRadius = 20; // Köşe yuvarlatma yarıçapı
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath path = new GraphicsPath();

            int x = offsetX;
            int y = offsetY;

            path.StartFigure();
            // Sol üst köşe
            path.AddArc(x, y, cornerRadius, cornerRadius, 180, 90);
            path.AddLine(x + cornerRadius, y, x + width - cornerRadius, y);
            // Sağ üst köşe
            path.AddArc(x + width - cornerRadius, y, cornerRadius, cornerRadius, 270, 90);
            path.AddLine(x + width, y + cornerRadius, x + width, y + height - cornerRadius);
            // Sağ alt köşe
            path.AddArc(x + width - cornerRadius, y + height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddLine(x + width - cornerRadius, y + height, x + cornerRadius, y + height);
            // Sol alt köşe
            path.AddArc(x, y + height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.AddLine(x, y + height - cornerRadius, x, y + cornerRadius);

            path.CloseFigure();

            Brush brush = new SolidBrush(Color.LightBlue);
            g.FillPath(brush, path);
            g.DrawPath(Pens.Black, path);

            brush.Dispose();
            path.Dispose();

        }



        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
