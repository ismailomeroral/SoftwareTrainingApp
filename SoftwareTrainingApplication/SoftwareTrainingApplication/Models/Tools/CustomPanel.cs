using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.Models.Tools
{
    internal class CustomPanel : Panel
    {
        private int topLeftRadius = 10;
        private int topRightRadius = 10;
        private int bottomLeftRadius = 10;
        private int bottomRightRadius = 10;

        [Category("Custom Radius")]
        public int TopLeftRadius
        {
            get => topLeftRadius;
            set { topLeftRadius = value; UpdateMinimumSize(); Invalidate(); }
        }

        [Category("Custom Radius")]
        public int TopRightRadius
        {
            get => topRightRadius;
            set { topRightRadius = value; UpdateMinimumSize(); Invalidate(); }
        }

        [Category("Custom Radius")]
        public int BottomLeftRadius
        {
            get => bottomLeftRadius;
            set { bottomLeftRadius = value; UpdateMinimumSize(); Invalidate(); }
        }

        [Category("Custom Radius")]
        public int BottomRightRadius
        {
            get => bottomRightRadius;
            set { bottomRightRadius = value; UpdateMinimumSize(); Invalidate(); }
        }

        private void UpdateMinimumSize()
        {
            int minWidth = Math.Max(topLeftRadius + topRightRadius, bottomLeftRadius + bottomRightRadius);
            int minHeight = Math.Max(topLeftRadius + bottomLeftRadius, topRightRadius + bottomRightRadius);

            this.MinimumSize = new Size(minWidth, minHeight);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();

            // Sol üst köşe
            if (TopLeftRadius > 0)
                path.AddArc(new Rectangle(0, 0, TopLeftRadius * 2, TopLeftRadius * 2), 180, 90);
            else
                path.AddLine(0, 0, 0, 0); // Radius 0 ise düz çiz

            // Üst çizgi
            path.AddLine(TopLeftRadius, 0, Width - TopRightRadius, 0);

            // Sağ üst köşe
            if (TopRightRadius > 0)
                path.AddArc(new Rectangle(Width - TopRightRadius * 2, 0, TopRightRadius * 2, TopRightRadius * 2), 270, 90);
            else
                path.AddLine(Width, 0, Width, 0); // Radius 0 ise düz çiz

            // Sağ çizgi
            path.AddLine(Width, TopRightRadius, Width, Height - BottomRightRadius);

            // Sağ alt köşe
            if (BottomRightRadius > 0)
                path.AddArc(new Rectangle(Width - BottomRightRadius * 2, Height - BottomRightRadius * 2, BottomRightRadius * 2, BottomRightRadius * 2), 0, 90);
            else
                path.AddLine(Width, Height, Width, Height); // Radius 0 ise düz çiz

            // Alt çizgi
            path.AddLine(Width - BottomRightRadius, Height, BottomLeftRadius, Height);

            // Sol alt köşe
            if (BottomLeftRadius > 0)
                path.AddArc(new Rectangle(0, Height - BottomLeftRadius * 2, BottomLeftRadius * 2, BottomLeftRadius * 2), 90, 90);
            else
                path.AddLine(0, Height, 0, Height); // Radius 0 ise düz çiz

            // Sol çizgi
            path.AddLine(0, Height - BottomLeftRadius, 0, TopLeftRadius);

            path.CloseFigure();

            this.Region = new Region(path);

            // İçini boyamak
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillPath(new SolidBrush(this.BackColor), path);
        }
    }
}
