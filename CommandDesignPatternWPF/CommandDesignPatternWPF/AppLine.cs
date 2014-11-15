using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace CommandDesignPatternWPF
{
    public class AppLine
    {

        private readonly Point start;
        private readonly Point end;

        public AppLine( Point start, Point end )
        {
            this.start = start;
            this.end = end;
        }

        public Drawing buildDrawing()
        {
            GeometryDrawing drawing = new GeometryDrawing();
            drawing.Pen = new Pen(Brushes.Black, 1);
            drawing.Geometry = buildEdge();
            return drawing;
        }

        private Geometry buildEdge()
        {
            return new LineGeometry(this.start, this.end);
        }

    }
}
