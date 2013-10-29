using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace CSGraph
{
    public class Edge
    {
        private const char DELIMITER = ';';

        private readonly GraphPoint start;
        private readonly GraphPoint end;
        private readonly float penWidth;

        public Edge(GraphPoint start, GraphPoint end, float penWidth)
        {
            this.start = start;
            this.end = end;
            this.penWidth = penWidth;
        }

        ~Edge()
        {
            //
        }

        public void draw(Graphics graphics)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            pen.Width = this.penWidth;
            graphics.DrawLine(pen, this.start.Position, this.end.Position);
        }

        public override string ToString()
        {
            return "[" + start + "]-[" + end + "] (" + penWidth + ")";
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
                    graph.add(Edge.parse(graph, line));
                }
                reader.Close();
            }
            catch (Exception e)
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

        private static Edge parse(Graph graph, String line)
        {
            try
            {
                string[] lineItem = line.Split(Edge.DELIMITER);
                return new Edge(
                            graph.getPoint(Convert.ToInt32(lineItem[0])),
                            graph.getPoint(Convert.ToInt32(lineItem[1])),
                            Convert.ToSingle(lineItem[2]));
            }
            catch (Exception e)
            {
                throw new GraphParseException("Edge parse error.", line, e);
            }
        }        

    }
}
