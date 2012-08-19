using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TimerApp
{
    public static class CustomExtensions
    {

        public static void DrawRectangle(this Graphics graphics, Pen pen, RectangleF rect)
        {
            graphics.DrawRectangle(pen, rect.Left, rect.Top, rect.Width, rect.Height);
        }

    }
}
