using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPatternWPF
{
    public class ChangeColorCommand : EditorCommand
    {

        private CDPShape shape;
        private Color originalColor;
        private Color newColor;

        public ChangeColorCommand(CDPShape shape, Color newColor)
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
