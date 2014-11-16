using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CommandDesignPatternWPF.commands;
using CommandDesignPatternWPF.shapes;

namespace CommandDesignPatternWPF.commands
{
    public class DrawCommand : Command
    {

        public DrawCommand(List<IShape> shapes, IShape shape) : base(shapes, shape)
        {
        }

        public override void process()
        {
            this.shapes.Add(this.shape);
        }

        public override void undo()
        {
            this.shapes.Remove(this.shape);
        }

    }
}
