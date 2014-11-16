using CommandDesignPatternWPF.shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPatternWPF.commands
{
    public class ChangePenWidthCommand : Command
    {

        private double originalWidth;
        private double newWidth;

        public ChangePenWidthCommand(List<IShape> shapes, IShape shape, double newWidth)
            : base(shapes, shape)
        {
            this.originalWidth = this.shape.PenWidth;
            this.newWidth = newWidth;
        }

        public override void process()
        {
            this.shape.PenWidth = this.newWidth;
        }

        public override void undo()
        {
            this.shape.PenWidth = this.originalWidth;
        }

    }
}
