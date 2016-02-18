using CommandDesignPatternWPF.shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CommandDesignPatternWPF.commands
{
    public class ChangePenColorCommand : ChangeColorCommand
    {

        protected override Nullable<Color> Color
        {
            get { return this.shape.PenColor; }
            set { this.shape.PenColor = value; }
        }

        public ChangePenColorCommand(List<IShape> shapes, IShape shape, Nullable<Color> newColor)
            : base(shapes, shape, newColor)
        {
        }

    }
}
