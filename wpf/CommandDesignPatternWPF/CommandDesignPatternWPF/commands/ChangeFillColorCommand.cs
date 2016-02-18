using CommandDesignPatternWPF.commands;
using CommandDesignPatternWPF.shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace CommandDesignPatternWPF.commands
{
    public class ChangeFillColorCommand : ChangeColorCommand
    {

        protected override Nullable<Color> Color
        {
            get { return this.shape.FillColor; }
            set { this.shape.FillColor = value; }
        }

        public ChangeFillColorCommand(List<IShape> shapes, IShape shape, Nullable<Color> newColor)
            : base(shapes, shape, newColor)
        {
        }

    }
}
