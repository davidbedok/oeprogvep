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
    public class GraphEdge
    {
        private const String FILE_EXTENSION = ".edges";
        private const char DELIMITER = ';';

        private readonly GraphPoint start;
        private readonly GraphPoint end;
        private readonly double width;

        public GraphEdge(GraphPoint start, GraphPoint end, double width)
        {
            this.start = start;
            this.end = end;
            this.width = width;
        }

        public Drawing buildDrawing()
        {
            GeometryDrawing drawing = new GeometryDrawing();
            drawing.Pen = new Pen(Brushes.Black, this.width);
            drawing.Geometry = buildEdge();
            return drawing;
        }

        private Geometry buildEdge()
        {
            return new LineGeometry(this.start.Position, this.end.Position);
        }

        public override string ToString()
        {
            return "[" + start + "]-[" + end + "] (" + width + ")";
        }

        public static String buildPath(String directory, String baseFileName)
        {
            return directory + Path.DirectorySeparatorChar + baseFileName + GraphEdge.FILE_EXTENSION;
        }

        public static void load(string fileName, Graph graph)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(File.Open(fileName, FileMode.Open));
                String line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    graph.add(GraphEdge.parse(graph, line));
                }
            }
            catch (System.Exception e)
            {
                throw new BadFileFormatException("Unexpected error while parsing '" + fileName + "'.", e);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private static GraphEdge parse(Graph graph, String line)
        {
            try
            {
                string[] lineItem = line.Split(GraphEdge.DELIMITER);
                return new GraphEdge(
                            graph.getPoint(Convert.ToInt32(lineItem[0])),
                            graph.getPoint(Convert.ToInt32(lineItem[1])),
                            Convert.ToDouble(lineItem[2]));
            }
            catch (System.Exception e)
            {
                throw new GraphParseException("Edge parse error.", line, e);
            }
        }

    }
}
