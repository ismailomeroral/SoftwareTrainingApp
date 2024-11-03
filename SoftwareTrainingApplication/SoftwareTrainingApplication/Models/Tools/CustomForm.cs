using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.Models.Tools
{
    internal class CustomForm : Form
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CustomForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomForm";
            this.ResumeLayout(false);
            this.Resize += CustomForm_Resize;

        }
        private int gripSize = 16; // Tutma kenar boyutu
        private int cornerRadius = 20; // Köşe yarıçapı

        public int GripSize { get => gripSize; set { gripSize = value; this.Invalidate(); } }
        public int CornerRadius { get => cornerRadius; set { cornerRadius = value; this.Invalidate(); }  }

        public CustomForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(gripSize);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

            this.SizeChanged += (sender, e) =>
            {
                this.Invalidate();
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.Invalidate();
                }
            };
        }
        private void CustomForm_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
            this.Update();
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Invalidate();
                ctrl.Update();
            }
        }
        public void SetDesktop(int mowX, int mowY)
        {
            SetDesktopLocation(MousePosition.X - mowX, MousePosition.Y - mowY);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Anti-aliasing özelliğini etkinleştir

            // Arka planı temizle
            e.Graphics.Clear(this.BackColor);

            // Köşeleri yuvarlat ve formu yeniden boyutlandırma
            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90);
                path.AddLine(cornerRadius, 0, this.Width - cornerRadius, 0);
                path.AddArc(new Rectangle(this.Width - cornerRadius, 0, cornerRadius, cornerRadius), -90, 90);
                path.AddLine(this.Width, cornerRadius, this.Width, this.Height - cornerRadius);
                path.AddArc(new Rectangle(this.Width - cornerRadius, this.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90);
                path.AddLine(this.Width - cornerRadius, this.Height, cornerRadius, this.Height);
                path.AddArc(new Rectangle(0, this.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90);
                path.CloseFigure();
                this.Region = new Region(path);
            }
        }
        protected override void WndProc(ref Message m)
        {
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;
            const int WM_NCHITTEST = 0x84;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                Point pos = PointToClient(new Point(m.LParam.ToInt32()));

                if (pos.X >= ClientSize.Width - gripSize && pos.Y >= ClientSize.Height - gripSize)
                {
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                    return;
                }
                if (pos.X <= gripSize && pos.Y >= ClientSize.Height - gripSize)
                {
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                    return;
                }
                if (pos.X <= gripSize && pos.Y <= gripSize)
                {
                    m.Result = (IntPtr)HTTOPLEFT;
                    return;
                }
                if (pos.X >= ClientSize.Width - gripSize && pos.Y <= gripSize)
                {
                    m.Result = (IntPtr)HTTOPRIGHT;
                    return;
                }
                if (pos.X <= gripSize)
                {
                    m.Result = (IntPtr)HTLEFT;
                    return;
                }
                if (pos.X >= ClientSize.Width - gripSize)
                {
                    m.Result = (IntPtr)HTRIGHT;
                    return;
                }
                if (pos.Y <= gripSize)
                {
                    m.Result = (IntPtr)HTTOP;
                    return;
                }
                if (pos.Y >= ClientSize.Height - gripSize)
                {
                    m.Result = (IntPtr)HTBOTTOM;
                    return;
                }
            }

            base.WndProc(ref m);
        }
    }
}
