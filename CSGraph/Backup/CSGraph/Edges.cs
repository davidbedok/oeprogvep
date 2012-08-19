using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CSGraph
{
    public class Edges
    {

        private int pointAid;
        private int pointBid;
        private double penWidth;

        public static uint numberOfEdges = 0;
        public static string errorText = "";
        public const uint MAXEDGES = 20;

        public int PpointAid
        {
            get { return pointAid; }
        }


        public int PpointBid
        {
            get { return pointBid; }
        }

        public double PpenWidth
        {
            get { return penWidth; }
            set { penWidth = value; }
        }

        public Edges(int pointAid, int pointBid, double penWidth)
        {
            this.pointAid = pointAid;
            this.pointBid = pointBid;
            this.penWidth = penWidth;
            ++numberOfEdges;
        }

        ~Edges()
        {
            --numberOfEdges;
        }

        public override string ToString()
        {
            return "[" + pointAid + "]-[" + pointBid + "] (" + penWidth + ")";
        }

        public static Edges[] LoadFromFile(string filename)
        {
            errorText = "";
            Edges[] ret = new Edges[Edges.MAXEDGES];
            string line;
            string[] lineItem;
            try
            {
                StreamReader sr = new StreamReader(File.Open(filename, FileMode.Open));
                line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    lineItem = line.Split(';');
                    ret[numberOfEdges] = new Edges(
                            Convert.ToInt32(lineItem[0]),
                            Convert.ToInt32(lineItem[1]),
                            Convert.ToDouble(lineItem[2]));
                }
                sr.Close();
            }
            catch (Exception e)
            {
                errorText = e.ToString();
            }

            return ret;
        }        

    }
}
