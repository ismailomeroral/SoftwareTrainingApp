using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.Models.Tools
{
    internal class RotateLabel: Label
    {
        private float rotationAngle = 0f;

        [Category("Appearance")]
        public float RotationAngle
        {
            get => rotationAngle;
            set { rotationAngle = value; Invalidate(); } // Değer değiştiğinde yeniden çiz
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            // Label merkezini referans noktası olarak alarak metni döndür
            e.Graphics.TranslateTransform(ClientSize.Width / 2, ClientSize.Height / 2);
            e.Graphics.RotateTransform(rotationAngle);
            e.Graphics.TranslateTransform(-ClientSize.Width / 2, -ClientSize.Height / 2);

            // Metni dikey ve yatay olarak ortalamak için sınırları genişlet
            using (Brush brush = new SolidBrush(this.ForeColor))
            {
                StringFormat stringFormat = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                // Daha geniş bir RectangleF oluştur
                float adjustedWidth = Math.Max(ClientSize.Width, ClientSize.Height);
                float adjustedHeight = adjustedWidth;

                RectangleF rect = new RectangleF((ClientSize.Width - adjustedWidth) / 2, (ClientSize.Height - adjustedHeight) / 2, adjustedWidth, adjustedHeight);
                e.Graphics.DrawString(Text, Font, brush, rect, stringFormat);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate(); // Boyut değiştiğinde yeniden çiz
        }
    }
}
