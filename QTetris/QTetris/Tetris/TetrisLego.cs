using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace QTetris
{
    public class TetrisLego : System.Object
    {
        public static float MARGIN = 2;        

        private Color color;
        private bool isEmpty;
        
        private float size_width;
        private float size_height;

        public Color LegoColor
        {
            get { return color; }
            set { color = value; }
        }

        public bool IsEmpty
        {
            get { return isEmpty; }
        }

        public TetrisLego(Color color, float size_width, float size_height)
        {
            this.color = color;
            this.size_width = size_width;
            this.size_height = size_height;
            isEmpty = false;
        }

        public TetrisLego( float size_width, float size_height )
        {
            this.color = Color.FromArgb(255,255,255);
            this.size_width = size_width;
            this.size_height = size_height;
            isEmpty = true;
        }

        private void draw(Graphics g, Brush b, float x, float y)
        {           
            g.FillRectangle(b, x + TetrisLego.MARGIN, y + TetrisLego.MARGIN, size_width - TetrisLego.MARGIN * 2, size_height - TetrisLego.MARGIN * 2);
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, x + TetrisLego.MARGIN, y + TetrisLego.MARGIN, size_width - TetrisLego.MARGIN * 2, size_height - TetrisLego.MARGIN * 2);
        }

        public void draw(Graphics g, int pos_x, int pos_y)
        {
            Brush brush = new SolidBrush(color);
            draw(g, brush, pos_x * this.size_width, pos_y * this.size_height);
        }

        public void draw(Graphics g, Color c, int pos_x, int pos_y)
        {
            Brush brush = new SolidBrush(c);
            draw(g, brush, pos_x * this.size_width, pos_y * this.size_height);
        }

        public override string ToString()
        {
            return (this.isEmpty ? "X" : "O");
        }

    }
}
