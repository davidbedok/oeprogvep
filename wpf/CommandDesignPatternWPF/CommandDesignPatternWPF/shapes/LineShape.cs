﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace CommandDesignPatternWPF.shapes
{
    public class LineShape : CDPShape
    {

        private Point end;

        public LineShape(Nullable<Color> penColor, Nullable<Color> fillColor, double penWidth, Point start, Point end)
            : base(penColor, fillColor, penWidth, start)
        {
            this.end = end;
        }

        protected override Geometry buildGeometry()
        {
            return new LineGeometry(this.ReferencePoint, this.end);
        }

        public override string ToString()
        {
            return "Line" + base.ToString();
        }

    }
}
