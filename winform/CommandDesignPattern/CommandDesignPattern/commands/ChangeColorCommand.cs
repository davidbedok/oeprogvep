using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPattern
{
    public class ChangeColorCommand : EditorCommand
    {

        private Shape shape;
        private Color originalColor;
        private Color newColor;

        public ChangeColorCommand(Shape shape, Color newColor)
        {
            this.shape = shape;
            this.originalColor = shape.ShapeColor;
            this.newColor = newColor;
        }

        public void process(Graphics imgGra)
        {
            shape.ShapeColor = newColor;
            shape.draw(imgGra);
        }

        public void undo(Graphics imgGra)
        {
            shape.ShapeColor = originalColor;
            shape.draw(imgGra);
        }

    }
}
