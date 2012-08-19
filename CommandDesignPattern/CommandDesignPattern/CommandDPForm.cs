using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommandDesignPattern
{
    public partial class CommandDPForm : Form
    {
        private const int IMG_WIDTH = 640;
        private const int IMG_HEIGHT = 480;

        private float stretchX;
        private float stretchY;

        private Palette tool;
        
        private Point startCoord;
        private PointF startCoordF;
        private Point endCoord;
        private PointF endCoordF;
        
        private bool isDraw;

        private IEditor editor;

        public CommandDPForm()
        {
            InitializeComponent();
            this.pbImage.Image = new Bitmap(CommandDPForm.IMG_WIDTH, CommandDPForm.IMG_HEIGHT);
            
            Graphics imgGraphics = Graphics.FromImage(this.pbImage.Image);
            imgGraphics.Clear(Color.White);
            this.calcStretch();

            this.tool = Palette.LINE;
            this.tsbLine.Tag = Palette.LINE;
            this.tsbRectangle.Tag = Palette.RECTANGLE;
            this.tsbEllipse.Tag = Palette.ELLIPSE;

            this.tsbLeft.Tag = MoveType.LEFT;
            this.tsbUp.Tag = MoveType.UP;
            this.tsbRight.Tag = MoveType.RIGHT;
            this.tsbDown.Tag = MoveType.DOWN;

            this.tscbLineWidth.SelectedIndex = 0;
            this.tsbColor.BackColor = Color.Black;

            this.editor = new Editor();
            this.tscbShapes.Items.Add(new EmptyShape(Pens.White));
            this.tscbShapes.SelectedIndex = 0;
        }

        private void calcStretch()
        {
            this.stretchX = (float)this.pbImage.Width / CommandDPForm.IMG_WIDTH;
            this.stretchY = (float)this.pbImage.Height / CommandDPForm.IMG_HEIGHT;
        }

        private void CommandDPForm_Resize(object sender, EventArgs e)
        {
            this.calcStretch();
        }

        private void tsbDrawTool_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripButton)
            {
                ToolStripButton button = (ToolStripButton)sender;
                if (button.Tag is Palette)
                {
                    this.tool = (Palette)button.Tag;
                    this.tscbShapes.SelectedIndex = 0;
                }
            }
        }

        private void tsbColor_Click(object sender, EventArgs e)
        {
            DialogResult result = this.shapeColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (tscbShapes.SelectedItem is EmptyShape)
                {
                    this.tsbColor.BackColor = this.shapeColorDialog.Color;
                }
                else
                {
                    this.editor.changeColor(this.getGraphics(), (Shape)tscbShapes.SelectedItem, this.shapeColorDialog.Color);
                    this.pbImage.Invalidate();
                }
            }
        }

        private void pbImage_MouseDown(object sender, MouseEventArgs e)
        {
            this.startCoord = this.pbImage.PointToScreen(new Point(e.X, e.Y));
            this.startCoordF = this.convertPixelToCoord(e.X, e.Y);

            this.isDraw = true;
        }

        private PointF convertPixelToCoord(int x, int y)
        {
            return new PointF((int)(x / this.stretchX), (int)(y / this.stretchY));
        }

        private void pbImage_MouseMove(object sender, MouseEventArgs e)
        {
            int calcX = (int)(e.X / this.stretchX);
            int calcY = (int)(e.Y / this.stretchY);
            this.tsslCoords.Text = e.X + ":" + e.Y + "(" + calcX + ":" + calcY + ")";

            if (this.isDraw)
            {
                if (this.endCoord.X != 0)
                {
                    this.drawReversible();
                }
                this.endCoord = this.pbImage.PointToScreen(new Point(e.X, e.Y));
                this.drawReversible();
            }
        }

        private void drawReversible()
        {
            if (Palette.LINE == this.tool)
            {
                ControlPaint.DrawReversibleLine(this.startCoord, this.endCoord, Color.Black);
            }
            else
            {
                Rectangle rect = this.getRectFromCoords(this.startCoord, this.endCoord);
                ControlPaint.DrawReversibleFrame(rect, Color.Black, FrameStyle.Dashed);
            }
        }

        private Rectangle getRectFromCoords(Point start, Point end)
        {
            Size rectSize = new Size(end.X - start.X, end.Y - start.Y);
            return new Rectangle(start, rectSize);
        }

        private void pbImage_MouseUp(object sender, MouseEventArgs e)
        {
            this.endCoord = this.pbImage.PointToScreen(new Point(e.X, e.Y));
            this.endCoordF = this.convertPixelToCoord(e.X, e.Y);

            Pen drawPen = new Pen(this.tsbColor.BackColor, this.tscbLineWidth.SelectedIndex + 1);
            RectangleF rect = this.getRectFFromCoords(this.startCoordF, this.endCoordF);
            switch (this.tool)
            {
                case Palette.LINE:
                    this.addShape(this.getGraphics(), new LineShape(drawPen, this.startCoordF, this.endCoordF));
                    break;
                case Palette.RECTANGLE:
                    this.addShape(this.getGraphics(), new RectangleShape(drawPen, rect));
                    break;
                case Palette.ELLIPSE:
                    this.addShape(this.getGraphics(), new EllipseShape(drawPen, rect));
                    break;
            }
            
            this.endCoord = new Point(0, 0);
            this.isDraw = false;
            this.pbImage.Invalidate();
        }

        private RectangleF getRectFFromCoords(PointF start, PointF end)
        {
            SizeF rectSize = new SizeF(end.X - start.X, end.Y - start.Y);
            RectangleF rect = new RectangleF(start, rectSize);
            if (rect.Width < 0)
            {
                rect = new RectangleF(rect.X + rect.Width, rect.Y, rect.Width * -1, rect.Height);
            }
            if (rect.Height < 0)
            {
                rect = new RectangleF(rect.X, rect.Y + rect.Height, rect.Width, rect.Height * -1);
            }
            return rect;
        }

        private Graphics getGraphics()
        {
            return Graphics.FromImage(this.pbImage.Image);
        }

        private void addShape(Graphics imgGra, Shape shape)
        {
            this.tscbShapes.Items.Add(shape);
            this.editor.drawShape(imgGra, shape);
        }

        private void tsbMove_Click(object sender, EventArgs e)
        {
            if (!(tscbShapes.SelectedItem is EmptyShape))
            {
                if (sender is ToolStripButton)
                {
                    ToolStripButton button = (ToolStripButton)sender;
                    if (button.Tag is MoveType)
                    {
                        this.editor.moveShape(this.getGraphics(), (Shape)tscbShapes.SelectedItem, (MoveType)button.Tag, 10);
                        this.pbImage.Invalidate();
                    }
                }
            }
        }

        private void tsbUndo_Click(object sender, EventArgs e)
        {
            this.editor.undo(Graphics.FromImage(this.pbImage.Image));
            this.pbImage.Invalidate();
        }

        private void tsbRedo_Click(object sender, EventArgs e)
        {
            this.editor.redo(Graphics.FromImage(this.pbImage.Image));
            this.pbImage.Invalidate();
        }

    }

}
