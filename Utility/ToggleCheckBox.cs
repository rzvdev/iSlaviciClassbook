﻿using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace iSlavici.Utility
{
    public class ToggleCheckBox : CheckBox
    {
        public ToggleCheckBox()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            Padding = new Padding(6);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            OnPaintBackground(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var geo = new Geometry();
            var rectn = new Rectangle(1, 3, Width - 5, Height - 6);
            var pen = new Pen(Brushes.DarkGray, 2);

            using (GraphicsPath path = (GraphicsPath)geo.RoundedRectanglePath(rectn, 9))
            {
                //e.Graphics.DrawPath(Checked ? Pens.Silver : Pens.LightGray, path);
                e.Graphics.DrawPath(pen, path);
            }

            pen.Dispose();
            int r = Height - 10;

            var rect = Checked ? new Rectangle(Width - r - 6, 5, r, r)
                           : new Rectangle(3, 5, r, r);

            var brs = new SolidBrush(Color.SeaGreen);
            e.Graphics.FillEllipse(Checked ? brs : Brushes.Gray, rect);

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
        }
    }
}
