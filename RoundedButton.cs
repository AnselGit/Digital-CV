using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace DigitalCV
{
    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class RoundedButton : Button
    {
        public int BorderRadius { get; set; } = 20;
        public Color BackgroundColor { get; set; } = Color.MediumSlateBlue;
        public Color TextColor { get; set; } = Color.White;

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            ForeColor = TextColor;
            BackColor = BackgroundColor;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Prevent crash in Designer
            if (this.DesignMode) return;

            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            using (GraphicsPath path = GetRoundPath(rect, BorderRadius))
            {
                this.Region = new Region(path);

                using (SolidBrush brush = new SolidBrush(BackgroundColor))
                    graphics.FillPath(brush, path);

                using (StringFormat sf = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                })
                using (SolidBrush textBrush = new SolidBrush(TextColor))
                {
                    graphics.DrawString(this.Text, this.Font, textBrush, rect, sf);
                }
            }
        }

        private GraphicsPath GetRoundPath(Rectangle bounds, int radius)
        {
            float r = radius;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(bounds.Left, bounds.Top, r, r, 180, 90);
            path.AddArc(bounds.Right - r, bounds.Top, r, r, 270, 90);
            path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}


