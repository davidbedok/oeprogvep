using CommandDesignPatternWPF.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace CommandDesignPatternWPF
{
    public class ChangeColorCommand : Command
    {

        private Color originalColor;
        private Color newColor;

        public ChangeColorCommand(List<IShape> shapes, IShape shape, Color newColor) : base(shapes, shape)
        {
            this.originalColor = shape.FillColor;
            this.newColor = newColor;
        }

        public override void process()
        {
            shape.FillColor = newColor;
        }

        public override void undo()
        {
            shape.FillColor = originalColor;
        }

    }
}
