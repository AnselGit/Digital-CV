using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DigitalCV
{
    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class RoundedButton : Button
    {
        [Browsable(true)]
        public int BorderRadius { get; set; } = 20;

        [Browsable(true)]
        public Color NormalBackColor { get; set; } = Color.MediumSlateBlue;

        [Browsable(true)]
        public Color HoverBackColor { get; set; } = Color.RoyalBlue;

        [Browsable(true)]
        public Color ClickBackColor { get; set; } = Color.MidnightBlue;

        [Browsable(true)]
        public Color TextColor { get; set; } = Color.White;

        private Color currentBackColor;

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            ForeColor = TextColor;
            currentBackColor = NormalBackColor;

            this.MouseEnter += (s, e) => { currentBackColor = HoverBackColor; Invalidate(); };
            this.MouseLeave += (s, e) => { currentBackColor = NormalBackColor; Invalidate(); };
            this.MouseDown += (s, e) => { currentBackColor = ClickBackColor; Invalidate(); };
            this.MouseUp += (s, e) => { currentBackColor = HoverBackColor; Invalidate(); };
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (this.DesignMode) return;

            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            using (GraphicsPath path = GetRoundPath(rect, BorderRadius))
            {
                this.Region = new Region(path);
                using (SolidBrush brush = new SolidBrush(currentBackColor))
                    g.FillPath(brush, path);

                using (StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                })
                using (SolidBrush textBrush = new SolidBrush(TextColor))
                    g.DrawString(this.Text, this.Font, textBrush, rect, sf);
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
