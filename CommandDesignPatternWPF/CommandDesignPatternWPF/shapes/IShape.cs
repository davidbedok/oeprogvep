using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace CommandDesignPatternWPF
{
    public interface IShape
    {
        Color PenColor { get; set; }
        Color FillColor { get; set; }
        Point ReferencePoint { get; set; }

        Drawing buildDrawing();
    }
}
