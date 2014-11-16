using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CommandDesignPatternWPF
{
    public class Editor : IEditor
    {

        private readonly Image image;
        private readonly List<IShape> shapes;
        private readonly IEditorHistory history;

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

        public void changeColor(IShape shape, Color newColor)
        {
            this.history.addCommand(new ChangeColorCommand(this.shapes, shape, newColor));
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
