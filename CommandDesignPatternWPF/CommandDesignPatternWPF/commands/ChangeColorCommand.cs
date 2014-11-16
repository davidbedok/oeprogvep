using CommandDesignPatternWPF.shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CommandDesignPatternWPF.commands
{
    public abstract class ChangeColorCommand : Command
    {

        private Nullable<Color> originalColor;
        private Nullable<Color> newColor;

        protected abstract Nullable<Color> Color { get; set; }

        public ChangeColorCommand(List<IShape> shapes, IShape shape, Nullable<Color> newColor)
            : base(shapes, shape)
        {
            this.originalColor = this.Color;
            this.newColor = newColor;
        }

        public override void process()
        {
            this.Color = this.newColor;
        }

        public override void undo()
        {
            this.Color = this.originalColor;
        }

    }
}
