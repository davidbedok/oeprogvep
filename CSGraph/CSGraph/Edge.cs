using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CSGraph
{
    public class Edge
    {

        private int startPointId;
        private int endPointId;
        private float penWidth;

        public int StartPointId
        {
            get { return startPointId; }
        }

        public int EndPointId
        {
            get { return endPointId; }
        }

        public float PenWidth
        {
            get { return penWidth; }
            set { penWidth = value; }
        }

        public Edge(int startPointId, int endPointId, float penWidth)
        {
            this.startPointId = startPointId;
            this.endPointId = endPointId;
            this.penWidth = penWidth;
        }

        ~Edge()
        {
            // 
        }

        public override string ToString()
        {
            return "[" + startPointId + "]-[" + endPointId + "] (" + penWidth + ")";
        }

    }
}
