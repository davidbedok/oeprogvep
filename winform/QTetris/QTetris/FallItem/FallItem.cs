using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace QTetris
{
    public abstract class FallItem : System.Object
    {
        private const byte MAX_STATE_NUMBER = 4;
        public const byte MAX_STATE_WINDOW_SIZE = 4;
        public const byte SIZE_WIDTH = 25;
        public const byte SIZE_HEIGHT = 25;
        public const float MARGIN = 2;  

        protected int pos_x;
        protected int pos_y;
        protected FallItemState[] states;
        protected byte actualState;
        protected Color color;

        public FallItemState this[int stateindex]
        {
            set
            {
                states[stateindex] = value;
            }
            get
            {
                return states[stateindex];
            }
        }

        public FallItemState ActState
        {
            get
            {
                return states[actualState];
            }
        }

        public byte StateWindowMaxColumn
        {
            get {
                return this.states[this.actualState].ColumnSize;
            }
        }

        public byte StateWindowMaxRow
        {
            get
            {
                return this.states[this.actualState][0].RowSize;
            }
        }

        public int X
        {
            get { return pos_x; }
        }

        public int Y
        {
            get { return pos_y; }
        }

        public Color ItemColor
        {
            get { return color; }
        }

        public FallItem(Color color, int pos_x, int pos_y, byte actualState)
        {
            this.color = color;
            this.pos_x = pos_x;
            this.pos_y = pos_y;

            this.states = new FallItemState[FallItem.MAX_STATE_NUMBER];
            this.actualState = actualState;
        }

        public void fall()
        {
            ++pos_y;
        }

        public void undoFall()
        {
            --pos_y;
        }

        public void left()
        {
            --pos_x;
        }

        public void right()
        {
            ++pos_x;
        }

        public bool isLego(int column, int row)
        {
            return (this.states[this.actualState][column][row] == 1);
        }

        public void rotate()
        {
            if (this.actualState < FallItem.MAX_STATE_NUMBER - 1)
            {
                ++actualState;
            }
            else
            {
                this.actualState = 0;
            }
        }

        public void undoRotate()
        {
            if (this.actualState > 0)
            {
                --actualState;
            }
            else
            {
                this.actualState = FallItem.MAX_STATE_NUMBER - 1;
            }
        }

        protected void draw(Graphics g, Brush b, float x, float y)
        {
            g.FillRectangle(b, x + FallItem.MARGIN, y + FallItem.MARGIN, FallItem.SIZE_WIDTH - FallItem.MARGIN * 2, FallItem.SIZE_HEIGHT - FallItem.MARGIN * 2);
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, x + FallItem.MARGIN, y + FallItem.MARGIN, FallItem.SIZE_WIDTH - FallItem.MARGIN * 2, FallItem.SIZE_HEIGHT - FallItem.MARGIN * 2);
        }

        protected void draw(Graphics g, int pos_x, int pos_y)
        {
            Brush brush = new SolidBrush(this.color);
            draw(g, brush, pos_x * FallItem.SIZE_WIDTH, pos_y * FallItem.SIZE_HEIGHT);
        }

        protected void draw(Graphics g, Color c, int pos_x, int pos_y)
        {
            Brush brush = new SolidBrush(c);
            draw(g, brush, pos_x * FallItem.SIZE_WIDTH, pos_y * FallItem.SIZE_HEIGHT);
        }

        public void drawItem( Graphics g )
        {
            for (int i = 0; i < this.StateWindowMaxColumn; i++)
            {
                for (int j = 0; j < this.StateWindowMaxRow; j++)
                {
                    if (this.isLego(i, j))
                    {
                        this.draw(g, j, i);
                    }
                    else
                    {
                        this.draw(g, Color.FromArgb(255,255,255), j, i);
                    }
                }
            }
        }

        public static FallItem getNewFallItem(Random rand, int max_x)
        {
            FallItem fallItem = null;
            int start_x = rand.Next(0, max_x - FallItem.MAX_STATE_WINDOW_SIZE);
            int start_y = 0;
            int r = rand.Next(0, 200);
            int g = rand.Next(0, 200);
            int b = rand.Next(0, 200);
            byte actualState = (byte)rand.Next(0, FallItem.MAX_STATE_NUMBER);

            int fallItemtype = rand.Next(0, 8);
            switch (fallItemtype)
            {
                case 0:
                    fallItem = new FallItemShortL(Color.FromArgb(r, g, b), start_x, start_y, actualState);
                    break;
                case 1:
                    fallItem = new FallItemShortT(Color.FromArgb(r, g, b), start_x, start_y, actualState);
                    break;
                case 2:
                    fallItem = new FallItemLine(Color.FromArgb(r, g, b), start_x, start_y, actualState);
                    break;
                case 3:
                    fallItem = new FallItemCube(Color.FromArgb(r, g, b), start_x, start_y, actualState);
                    break;
                case 4:
                    fallItem = new FallItemL(Color.FromArgb(r, g, b), start_x, start_y, actualState);
                    break;
                case 5:
                    fallItem = new FallItemZ(Color.FromArgb(r, g, b), start_x, start_y, actualState);
                    break;
                case 6:
                    fallItem = new FallItemLMirror(Color.FromArgb(r, g, b), start_x, start_y, actualState);
                    break;
                case 7:
                    fallItem = new FallItemZMirror(Color.FromArgb(r, g, b), start_x, start_y, actualState);
                    break;
            }

            return fallItem;
        }

    }
}
