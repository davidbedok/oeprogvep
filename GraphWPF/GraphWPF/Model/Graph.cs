using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows.Media;
using GraphWPF.Exception;

namespace GraphWPF.Model
{
    public class Graph
    {

        private List<GraphPoint> points;
        private List<GraphEdge> edges;

        public Graph()
        {
            this.points = new List<GraphPoint>();
            this.edges = new List<GraphEdge>();
        }

        public void add(GraphPoint point)
        {
            this.points.Add(point);
        }

        public void add(GraphEdge edge)
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

        public DrawingImage getImage()
        {
            return new DrawingImage(this.buildDrawing());
        }

        private Drawing buildDrawing()
        {
            DrawingGroup group = new DrawingGroup();
            for (int i = 0; i < this.points.Count; i++)
            {
                group.Children.Add(this.points[i].buildDrawing());
            }
            for (int i = 0; i < this.edges.Count; i++)
            {
                group.Children.Add(this.edges[i].buildDrawing());
            }
            return group;
        }

        public static Graph load(String fileName)
        {
            Graph graph = new Graph();
            try
            {
                String directory = Path.GetDirectoryName(fileName);
                String baseFileName = Path.GetFileNameWithoutExtension(fileName);
                String pointsFileName = GraphPoint.buildPath(directory, baseFileName);
                String edgesFileName = GraphEdge.buildPath(directory, baseFileName);

                GraphPoint.load(pointsFileName, graph);
                GraphEdge.load(edgesFileName, graph);
            }
            catch (System.Exception e)
            {
                throw new BadFileFormatException("Unexpected error while parsing '" + fileName + "'.", e);
            }
            return graph;
        }

    }
}
