using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.Models.CodeBench.Parts
{
    internal class ValuePart : Block
    {
        public dynamic value;
        public ValuePart insidePart;

        private TextBox editingTextBox;
        private bool isEditing = false;

        private bool isDragging = false;
        private Point dragStartPoint;

        public ValuePart()
        {
            // TextBox ayarları
            if (insidePart == null)
            {
                editingTextBox = new TextBox();
                editingTextBox.BorderStyle = BorderStyle.None;
                editingTextBox.Font = new Font("Arial", 10, FontStyle.Regular);
                editingTextBox.Visible = false;
                editingTextBox.Leave += EditingTextBox_Leave;
                editingTextBox.KeyDown += EditingTextBox_KeyDown;
                editingTextBox.TextChanged += EditingTextBox_TextChanged;


            }
        }

        public void OnPaint(PaintEventArgs e)
        {
            if (insidePart != null)
            {
                insidePart.OnPaint(e);
                return;
            }
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            // Yuvarlatılmış dikdörtgen çizimi
            GraphicsPath path = new GraphicsPath();
            float cornerRadius = (Size.Height / 2);
            path.StartFigure();
            path.AddArc(Location.X, Location.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            path.AddLine(Location.X + cornerRadius, Location.Y, Location.X + Size.Width - cornerRadius, Location.Y);
            path.AddArc(Location.X + Size.Width - cornerRadius * 2, Location.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            path.AddLine(Location.X + Size.Width, Location.Y + cornerRadius, Location.X + Size.Width, Location.Y + Size.Height - cornerRadius);
            path.AddArc(Location.X + Size.Width - cornerRadius * 2, Location.Y + Size.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            path.AddLine(Location.X + Size.Width - cornerRadius, Location.Y + Size.Height, Location.X + cornerRadius, Location.Y + Size.Height);
            path.AddArc(Location.X, Location.Y + Size.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            path.AddLine(Location.X, Location.Y + Size.Height - cornerRadius, Location.X, Location.Y + cornerRadius);
            path.CloseFigure();

            // Arka planı doldur ve kenarlık çiz
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillPath(brush, path);
            }
            g.DrawPath(Pens.Black, path);

            string displayText = string.IsNullOrEmpty(name) ? value.ToString() : name;

            // Metni çiz
            using (Font font = new Font("Arial", 10, FontStyle.Regular))
            {
                SizeF textSize = g.MeasureString(displayText, font);
                float textX = Location.X + (Size.Width - textSize.Width) / 2;
                float textY = Location.Y + (Size.Height - textSize.Height) / 2;
                g.DrawString(displayText, font, Brushes.Black, textX, textY);
            }

        }
        public void OnClick(MouseEventArgs e, Control parentControl)
        {
            if (isDragging)
                return;

            if (insidePart != null)
            {
                insidePart.OnClick(e, parentControl);
                return;
            }
            Rectangle rect = new Rectangle(Location.X, Location.Y, Size.Width, Size.Height);
         
            if (rect.Contains(e.Location) && !isEditing && string.IsNullOrEmpty(name))
            {
                // TextBox'u pozisyona göre ayarla ve göster
                editingTextBox.Text = value.ToString();
                editingTextBox.SetBounds(Location.X + 5, Location.Y + 5, Size.Width - 10, Size.Height - 10);
                editingTextBox.Visible = true;
                editingTextBox.Focus();
                parentControl.Controls.Add(editingTextBox);
                isEditing = true;
            }
        }
        private void EditingTextBox_Leave(object sender, EventArgs e)
        {
            // TextBox'dan çıkıldığında metni güncelle ve gizle
            value = editingTextBox.Text;
            editingTextBox.Visible = false;
            isEditing = false;
            editingTextBox.Parent?.Invalidate(); // Formu yeniden çiz
        }
        private void EditingTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter tuşuna basıldığında metni kaydet ve TextBox'u gizle
                value = editingTextBox.Text;
                editingTextBox.Visible = false;
                isEditing = false;
                editingTextBox.Parent?.Invalidate();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                // Escape tuşuna basıldığında düzenleme iptal edilir
                editingTextBox.Visible = false;
                isEditing = false;
            }
        }
        private void EditingTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSize(); // Metin değiştikçe boyutu güncelle
        }
        private void UpdateSize()
        {
            // Metnin genişliğine göre grafiğin genişliğini ayarla
            using (Graphics g = editingTextBox.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(editingTextBox.Text, editingTextBox.Font);
                Size.Width = (int)textSize.Width + 5; // Kenarlık için ekstra genişlik ekleyin
                if (this.Size.Width <= 40)
                    this.Size.Width = 40;
                editingTextBox.Width = Size.Width;
            }
        }

        public void OnMouseDown(MouseEventArgs e)
        {
            if (insidePart != null)
            {
                insidePart.OnMouseDown(e);
            }

            Rectangle rect = new Rectangle(Location.X, Location.Y, Size.Width, Size.Height);
            if (rect.Contains(e.Location))
            {
                isDragging = false; // Başlangıçta sürükleme modunda olmadığını varsay
                dragStartPoint = e.Location;
            }
        }

        public void OnMouseMove(MouseEventArgs e, Control control)
        {
            if (insidePart != null)
            {
                insidePart.OnMouseMove(e, control);
            }

            if (isDragging)
            {
                // Yeni konumu fare hareketine göre ayarla
                Location = (e.Location.X - dragStartPoint.X, e.Location.Y - dragStartPoint.Y);
                control.Invalidate(); // Formu yeniden çiz
            }
        }

        public void OnMouseUp(MouseEventArgs e)
        {
            if (insidePart != null)
            {
                insidePart.OnMouseUp(e);
            }

            isDragging = false; // Sürüklemeyi durdur
        }
    }
}
