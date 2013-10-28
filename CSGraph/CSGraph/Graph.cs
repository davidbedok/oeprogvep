using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace CSGraph
{
    public class Graph
    {
        
        private List<Point> points;
        private List<Edge> edges;

        public Point[] Points
        {
            get { return this.points.ToArray(); }
        }

        public Edge[] Edges
        {
            get { return this.edges.ToArray(); }
        }

        public Graph()
        {
            this.points = new List<Point>();
            this.edges = new List<Edge>();
        }

        public void addPoint( Point value ){
            this.points.Add(value);       
        }

        public void addEdge(Edge value)
        {
            this.edges.Add(value);
        }

        public Point getPoint(int id)
        {
            int i = 0;
            while (i < this.points.Count && this.points[i].Id != id)
            {
                i++;
            }
            return (i < this.points.Count ? this.points[i] : null);
        }

        public void draw(Graphics graphics)
        {
            
            for (int i = 0; i < this.points.Count; i++)
            {
                this.points[i].draw(graphics);           
            }
            for (int i = 0; i < this.edges.Count; i++)
            {
                this.edges[i].draw(graphics);   
            }
        }

        public static Graph load(String fileName)
        {
            Graph holder = new Graph();
            try
            {
                StreamReader sr = new StreamReader(File.Open(fileName, FileMode.Open));
                Point.load(sr.ReadLine(), holder);
                Edge.load(sr.ReadLine(), holder);
                sr.Close();
            }
            catch (Exception e)
            {
                //
            }
            return holder;
        }

    }
}
