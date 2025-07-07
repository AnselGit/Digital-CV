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
        private Color currentBackColor;

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            this.MouseEnter += (s, e) => {
                if (HoverBackColor != Color.Empty)
                {
                    currentBackColor = HoverBackColor;
                    Invalidate();
                }
            };
            this.MouseLeave += (s, e) => {
                if (NormalBackColor != Color.Empty)
                {
                    currentBackColor = NormalBackColor;
                    Invalidate();
                }
            };
            this.MouseDown += (s, e) => {
                if (ClickBackColor != Color.Empty)
                {
                    currentBackColor = ClickBackColor;
                    Invalidate();
                }
            };
            this.MouseUp += (s, e) => {
                if (HoverBackColor != Color.Empty)
                {
                    currentBackColor = HoverBackColor;
                    Invalidate();
                }
            };
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (NormalBackColor != Color.Empty)
            {
                currentBackColor = NormalBackColor;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Browsable(true)]
        public int BorderRadius { get; set; } = 20;

        [Category("Appearance")]
        [Browsable(true)]
        public Color NormalBackColor { get; set; }

        [Category("Appearance")]
        [Browsable(true)]
        public Color HoverBackColor { get; set; }

        [Category("Appearance")]
        [Browsable(true)]
        public Color ClickBackColor { get; set; }

        [Category("Appearance")]
        [Browsable(true)]
        public Color TextColor { get; set; } = Color.Empty;

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            if (DesignMode) return;

            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            using (GraphicsPath path = GetRoundPath(rect, BorderRadius))
            {
                this.Region = new Region(path);

                using (SolidBrush brush = new SolidBrush(currentBackColor == Color.Empty ? this.BackColor : currentBackColor))
                    g.FillPath(brush, path);

                using (StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                })
                using (SolidBrush textBrush = new SolidBrush(TextColor == Color.Empty ? this.ForeColor : TextColor))
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
