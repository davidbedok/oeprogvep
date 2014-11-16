using CommandDesignPatternWPF.commands;
using CommandDesignPatternWPF.shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CommandDesignPatternWPF.engine
{
    public class Editor : IEditor
    {

        private readonly Image image;
        private readonly List<IShape> shapes;
        private readonly IEditorHistory history;

        public IEditorHistory History
        {
            get { return this.history; }
        }   

        public Editor(Image image)
        {
            this.image = image;
            this.shapes = new List<IShape>();
            this.history = new EditorHistory();
        }

        public void drawImage()
        {
            this.image.Source = new DrawingImage(this.build());
        }

        private Drawing build()
        {
            DrawingGroup group = new DrawingGroup();
            group.Children.Add(buildFrame());
            for (int i = 0; i < this.shapes.Count; i++)
            {
                group.Children.Add(this.shapes[i].buildDrawing());
            }
            return group;
        }

        private GeometryDrawing buildFrame()
        {
            Geometry geometry = new RectangleGeometry(new Rect(new Point(0, 0), new Size(MainWindow.IMG_WIDTH, MainWindow.IMG_HEIGHT)));
            return new GeometryDrawing(Brushes.White, new Pen(Brushes.Black, 1), geometry);
        }

        public void draw(IShape shape)
        {
            this.history.addCommand(new DrawCommand(this.shapes, shape));
            this.drawImage();
        }

        public void changePenWidth(IShape shape, double width)
        {
            this.history.addCommand(new ChangePenWidthCommand(this.shapes, shape, width));
            this.drawImage();
        }

        public void changeColor(IShape shape, ColorType type, Nullable<Color> color)
        {
            switch (type)
            {
                case ColorType.FILL:
                    this.changeFillColor(shape, color);
                    break;
                case ColorType.PEN:
                    this.changePenColor(shape, color);
                    break;
            }
        }

        private void changeFillColor(IShape shape, Nullable<Color> color)
        {
            this.history.addCommand(new ChangeFillColorCommand(this.shapes, shape, color));
            this.drawImage();
        }

        private void changePenColor(IShape shape, Nullable<Color> color)
        {
            this.history.addCommand(new ChangePenColorCommand(this.shapes, shape, color));
            this.drawImage();
        }

        public void move(IShape shape, MoveType moveType, double param)
        {
            this.history.addCommand(new MoveCommand(this.shapes, shape, moveType, param));
            this.drawImage();
        }

        public void undo()
        {
            this.history.undo();
            this.drawImage();
        }

        public void redo()
        {
            this.history.redo();
            this.drawImage();
        }

    }
}
