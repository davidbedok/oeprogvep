using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace CommandDesignPatternWPF.shapes
{
    public class EmptyShape : CDPShape
    {

        public EmptyShape() : base(Colors.Black, Colors.White, 0, new Point(0, 0))
        {
        }

        protected override Geometry buildGeometry()
        {
            return null;
        }

        public override string ToString()
        {
            return "[none]";
        }

    }
}
