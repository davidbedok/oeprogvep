using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Bloxorz
{
    public class Position
    {
        private static readonly Pen FIELD_PEN_1 = new Pen(Color.FromArgb(50, 50, 50));
        private static readonly Pen FIELD_PEN_2 = new Pen(Color.FromArgb(150, 150, 150));
        private static readonly Brush FIELD_BRUSH = new SolidBrush(Color.FromArgb(200, 200, 200));
        private static readonly float ALIGN = 1;
        private static readonly float BORDER_WIDTH = 2;

        private static readonly Brush START_BRUSH = new HatchBrush(HatchStyle.DiagonalCross, Color.Gray, Color.LightGray);
        private static readonly Brush GOAL_BRUSH = new HatchBrush(HatchStyle.DiagonalCross, Color.Black);
        private static readonly Brush BLOCK_BRUSH = new HatchBrush(HatchStyle.SolidDiamond, Color.DarkOliveGreen, Color.GreenYellow);
        private static readonly Brush NEIGHBOR_BRUSH = new SolidBrush(Color.FromArgb(180, 180, 180));

        private int x;
        private int y;

        public int X
        {
            get { return this.x; }
        }

        public int Y
        {
            get { return this.y; }
        }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool check(Position position)
        {
            return check(position.x, position.y);
        }

        public bool check(int x, int y)
        {
            return this.x == x && this.y == y;
        }

        public Position dx( int d )
        {
            return new Position( this.x + d, y);
        }

        public Position dy(int d)
        {
            return new Position(this.x, y + d);
        }

        public static void drawField(Graphics g, RectangleF fieldRect )
        {
            drawCustomRect(g, fieldRect);
            g.FillRectangle(Position.FIELD_BRUSH, Position.innerRect(fieldRect));
        }

        public static void drawStart(Graphics g, RectangleF fieldRect)
        {
            drawCustomRect(g, fieldRect);
            g.FillRectangle(Position.START_BRUSH, Position.innerRect(fieldRect));
        }

        public static void drawGoal(Graphics g, RectangleF fieldRect)
        {
            drawCustomRect(g, fieldRect);
            g.FillRectangle(Position.GOAL_BRUSH, Position.innerRect(fieldRect));
        }

        public void drawBlock(Graphics g, float unit, bool isNeighbor)
        {
            RectangleF fieldRect = new RectangleF(this.y * unit, this.X * unit, unit, unit);
            if (isNeighbor)
            {
                g.FillRectangle(Position.NEIGHBOR_BRUSH, Position.innerRect(fieldRect));
            }
            else
            {
                g.FillRectangle(Position.BLOCK_BRUSH, Position.innerRect(fieldRect));
            }
        }

        private static void drawCustomRect(Graphics g, RectangleF fieldRect)
        {
            g.DrawLine(Position.FIELD_PEN_1, fieldRect.Left + Position.ALIGN, fieldRect.Top + Position.ALIGN, fieldRect.Right - Position.ALIGN, fieldRect.Top + Position.ALIGN);
            g.DrawLine(Position.FIELD_PEN_2, fieldRect.Right - Position.ALIGN, fieldRect.Top + Position.ALIGN, fieldRect.Right - Position.ALIGN, fieldRect.Bottom - Position.ALIGN);
            g.DrawLine(Position.FIELD_PEN_2, fieldRect.Right - Position.ALIGN, fieldRect.Bottom - Position.ALIGN, fieldRect.Left + Position.ALIGN, fieldRect.Bottom - Position.ALIGN);
            g.DrawLine(Position.FIELD_PEN_1, fieldRect.Left + Position.ALIGN, fieldRect.Bottom - Position.ALIGN, fieldRect.Left + Position.ALIGN, fieldRect.Top + Position.ALIGN);
        }

        private static RectangleF innerRect(RectangleF fieldRect)
        {
            return new RectangleF(fieldRect.Left + Position.BORDER_WIDTH, fieldRect.Top + Position.BORDER_WIDTH, fieldRect.Width - 2 * Position.BORDER_WIDTH, fieldRect.Height - 2 * Position.BORDER_WIDTH);
        }

        public override string ToString()
        {
            return "("+this.x+":"+this.y+")";
        }

    }
}
