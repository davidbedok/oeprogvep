using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace CSGraph
{
    public class EdgeUpgrade
    {

        private Point startPoint;
        private Point endPoint;
        private float penWidth;

        public Point StartPoint
        {
            get { return this.startPoint; }
        }

        public Point EndPoint
        {
            get { return this.endPoint; }
        }

        public float PenWidth
        {
            get { return penWidth; }
            set { penWidth = value; }
        }

        public EdgeUpgrade(Point pointA, Point pointB, float penWidth)
        {
            this.startPoint = pointA;
            this.endPoint = pointB;
            this.penWidth = penWidth;
        }

        ~EdgeUpgrade()
        {
            //
        }

        public override string ToString()
        {
            return "[" + startPoint + "]-[" + endPoint + "] (" + penWidth + ")";
        }

    }
}
