using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CSGraph
{
    public class GraphHolder
    {
        private Point[] points;
        private Edge[] edges;
        private EdgeUpgrade[] upgradeEdges;

        private uint numberOfPoints = 0;
        public const uint MAXPOINTS = 20;
        private uint numberOfEdges = 0;
        private string errorText = "";
        public const uint MAXEDGES = 20;

        public uint NumberOfPoints
        {
            get { return this.numberOfPoints; }
        }

        public uint NumberOfEdges
        {
            get { return this.numberOfEdges; }
        }

        public Point[] Points
        {
            get { return this.points; }
        }

        public Edge[] Edges
        {
            get { return this.edges; }
        }

        public EdgeUpgrade[] UpgradeEdges
        {
            get { return this.upgradeEdges; }
        }

        public GraphHolder()
        {
            this.points = new Point[GraphHolder.MAXPOINTS];
            this.edges = new Edge[GraphHolder.MAXEDGES];
            this.upgradeEdges = new EdgeUpgrade[GraphHolder.MAXEDGES];
        }

        public void addPoint( Point value ){
            if (this.numberOfPoints < GraphHolder.MAXPOINTS){
                this.points[this.numberOfPoints++] = value;
            }
        }

        public void addEdge(Edge value)
        {
            if (this.numberOfEdges < GraphHolder.MAXEDGES)
            {
                this.edges[this.numberOfEdges++] = value;
            }
        }

        public void addEdgeUpgrade(EdgeUpgrade value)
        {
            if (this.numberOfEdges < GraphHolder.MAXEDGES)
            {
                this.upgradeEdges[this.numberOfEdges++] = value;
            }
        }

        public int getPointIndexById(int id)
        {
            for (int i = 0; i < this.numberOfPoints; i++)
            {
                if (this.points[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public Point getPointById(int id)
        {
            for (int i = 0; i < this.numberOfPoints; i++)
            {
                if (this.points[i].Id == id)
                {
                    return this.points[i];
                }
            }
            return null;
        }

        public void LoadFromPointsFile(string filename)
        {
            errorText = "";
            string line;
            string[] lineItem;
            try
            {
                StreamReader sr = new StreamReader(File.Open(filename, FileMode.Open));
                line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    lineItem = line.Split(';');
                    this.addPoint(new Point(
                            Convert.ToInt32(lineItem[0]),
                            lineItem[1],
                            Convert.ToSingle(lineItem[2]),
                            Convert.ToSingle(lineItem[3]),
                            Convert.ToSingle(lineItem[4]),
                            Convert.ToByte(lineItem[5]),
                            Convert.ToByte(lineItem[6]),
                            Convert.ToByte(lineItem[7])));
                }
                sr.Close();
            }
            catch (Exception e)
            {
                this.errorText = e.ToString();
            }
        }

        public void LoadFromEdgesFile(string filename)
        {
            errorText = "";
            string line;
            string[] lineItem;
            try
            {
                StreamReader sr = new StreamReader(File.Open(filename, FileMode.Open));
                line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    lineItem = line.Split(';');
                    this.addEdge(new Edge(
                            Convert.ToInt32(lineItem[0]),
                            Convert.ToInt32(lineItem[1]),
                            Convert.ToSingle(lineItem[2])));
                }
                sr.Close();
            }
            catch (Exception e)
            {
                errorText = e.Message;
            }
        }

        public void LoadFromUpgradeEdgesFile(string filename)
        {
            errorText = "";
            string line;
            string[] lineItem;
            try
            {
                StreamReader sr = new StreamReader(File.Open(filename, FileMode.Open));
                line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    lineItem = line.Split(';');
                    this.addEdgeUpgrade(new EdgeUpgrade(
                            this.getPointById(Convert.ToInt32(lineItem[0])),
                            this.getPointById(Convert.ToInt32(lineItem[1])),
                            Convert.ToSingle(lineItem[2])));
                }
                sr.Close();
            }
            catch (Exception e)
            {
                errorText = e.Message;
            }
        }        

    }
}
