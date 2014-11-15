﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPatternWPF
{
    public class EmptyShape : CDPShape
    {

        public EmptyShape(Pen drawPen)
            : base(drawPen, new PointF(0,0))
        {
            
        }

        public override string ToString()
        {
            return "NONE";
        }

        public override void draw(Graphics imgGra)
        {
            
        }

        public override void erase(Graphics imgGra)
        {
            
        }

    }
}
