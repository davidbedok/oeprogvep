using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace CommandDesignPatternWPF.shapes
{
    public interface IShape
    {
        double PenWidth { get; set; }
        Nullable<Color> PenColor { get; set; }
        Nullable<Color> FillColor { get; set; }
        Point ReferencePoint { get; set; }

        Drawing buildDrawing();
    }
}
