using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPattern
{
    public interface IShape
    {
        Color ShapeColor { get; set; }
        PointF ReferencePoint { get; set; }
        void draw(Graphics imgGra);
        void erase(Graphics imgGra);
    }
}
