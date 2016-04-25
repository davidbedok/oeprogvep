using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Media;
using GraphWPF.Exception;

namespace GraphWPF.Model
{
    public class GraphEdge : GraphElement
    {

        public const String EXTENSION = ".edges";

        private readonly GraphPoint start;
        private readonly GraphPoint end;
        private readonly double width;

        protected override double PenThickness
        {
            get { return this.width; }
        }

        public GraphEdge(GraphPoint start, GraphPoint end, double width)
        {
            this.start = start;
            this.end = end;
            this.width = width;
        }

        protected override Brush getBrush()
        {
            return null;
        }

        protected override Geometry buildGeometry()
        {
            return new LineGeometry(this.start.Position, this.end.Position);
        }

        public override string ToString()
        {
            return "[" + start + "]-[" + end + "] (" + width + ")";
        }

        public static GraphEdge parse(Graph graph, String line)
        {
            try
            {
                string[] items = line.Split(DELIMITER);
                return new GraphEdge(
                            graph.getPoint(Convert.ToInt32(items[0])),
                            graph.getPoint(Convert.ToInt32(items[1])),
                            Convert.ToDouble(items[2]));
            }
            catch (System.Exception e)
            {
                throw new GraphParseException("Edge parse error.", line, e);
            }
        }

    }

}
