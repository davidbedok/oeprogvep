using CommandDesignPatternWPF.shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPatternWPF.commands
{
    public abstract class Command : EditorCommand
    {

        protected readonly List<IShape> shapes;
        protected readonly IShape shape;

        public Command(List<IShape> shapes, IShape shape)
        {
            this.shapes = shapes;
            this.shape = shape;
        }

        public abstract void process();
        public abstract void undo();

    }
}
