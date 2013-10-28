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

        private readonly Point startPoint;
        private readonly Point endPoint;
        private readonly float penWidth;

        public Edge(Point pointA, Point pointB, float penWidth)
        {
            this.startPoint = pointA;
            this.endPoint = pointB;
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
            graphics.DrawLine(pen,
                this.startPoint.PosX,
                this.startPoint.PosY,
                this.endPoint.PosX,
                this.endPoint.PosY);
        }

        public override string ToString()
        {
            return "[" + startPoint + "]-[" + endPoint + "] (" + penWidth + ")";
        }

        public static void load(string filename, Graph holder)
        {
            string line;
            string[] lineItem;
            try
            {
                StreamReader sr = new StreamReader(File.Open(filename, FileMode.Open));
                line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    lineItem = line.Split(';');
                    holder.addEdge(new Edge(
                            holder.getPoint(Convert.ToInt32(lineItem[0])),
                            holder.getPoint(Convert.ToInt32(lineItem[1])),
                            Convert.ToSingle(lineItem[2])));
                }
                sr.Close();
            }
            catch (Exception e)
            {
               // 
            }
        }     

        

    }
}
