using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPattern
{
    public class DrawCommand : EditorCommand
    {

        private IShape shape;

        public DrawCommand(IShape shape)
        {
            this.shape = shape;
        }

        public void process(Graphics imgGra)
        {
            shape.draw(imgGra);
        }

        public void undo(Graphics imgGra)
        {
            shape.erase(imgGra);
        }

    }
}
