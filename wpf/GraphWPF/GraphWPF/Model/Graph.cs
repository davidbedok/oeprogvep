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

        private List<GraphElement> elements;

        public Graph()
        {
            this.elements = new List<GraphElement>();
        }

        public void add(GraphElement element)
        {
            this.elements.Add(element);
        }

        public GraphPoint getPoint(int id)
        {
            int i = 0;
            while (i < this.elements.Count && this.elements[i] is GraphPoint && ((GraphPoint)this.elements[i]).Id != id)
            {
                i++;
            }
            return (i < this.elements.Count ? (GraphPoint)this.elements[i] : null);
        }

        public DrawingImage getImage()
        {
            return new DrawingImage(this.buildDrawing());
        }

        private Drawing buildDrawing()
        {
            DrawingGroup group = new DrawingGroup();
            foreach (GraphElement element in this.elements)
            {
                group.Children.Add(element.buildDrawing());
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
                String pointsFileName = GraphElement.buildPath(directory, baseFileName, GraphPoint.EXTENSION);
                String edgesFileName = GraphElement.buildPath(directory, baseFileName, GraphEdge.EXTENSION);

                GraphElement.load(pointsFileName, graph, GraphPoint.parse);
                GraphElement.load(edgesFileName, graph, GraphEdge.parse);
            }
            catch (System.Exception e)
            {
                throw new BadFileFormatException("Unexpected error while parsing '" + fileName + "'.", e);
            }
            return graph;
        }

    }
}
