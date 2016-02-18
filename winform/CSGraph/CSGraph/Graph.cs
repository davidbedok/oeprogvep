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
        
        private List<GraphPoint> points;
        private List<Edge> edges;

        public GraphPoint[] Points
        {
            get { return this.points.ToArray(); }
        }

        public Edge[] Edges
        {
            get { return this.edges.ToArray(); }
        }

        public Graph()
        {
            this.points = new List<GraphPoint>();
            this.edges = new List<Edge>();
        }

        public void add( GraphPoint point ){
            this.points.Add(point);       
        }

        public void add( Edge edge )
        {
            this.edges.Add(edge);
        }

        public GraphPoint getPoint(int id)
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
            Graph graph = new Graph();
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(File.Open(fileName, FileMode.Open));
                GraphPoint.load(reader.ReadLine(), graph);
                Edge.load(reader.ReadLine(), graph);                
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
            return graph;
        }

    }
}
