using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    public class Planet
    {

        private const char DELIMITER = ';';
        private const int SCALE_AVERAGE_DISTANCE = 10;
        private const int SCALE_RADIUS = 5000;

        private readonly String name;
        private readonly float averageDistance;
        private readonly int orbitalPeriodInDays;
        private float position;
        private readonly float radius;

        public Planet(String name, float averageDistance, int orbitalPeriodInDays, float position, float radius)
        {
            this.name = name;
            this.averageDistance = averageDistance;
            this.orbitalPeriodInDays = orbitalPeriodInDays;
            this.position = position;
            this.radius = radius;
        }

        public void draw(Graphics graphics, PointF centerPoint, Brush brush)
        {
            float calcAverageDistance = this.calcAverageDistance();
            this.drawOrbit(graphics, centerPoint, calcAverageDistance);
            this.drawPlanet(graphics, brush, centerPoint, calcAverageDistance);
        }

        private void drawOrbit(Graphics graphics, PointF centerPoint, float calcAverageDistance)
        {
            graphics.DrawEllipse(Pens.Gray, this.calcRect(centerPoint, calcAverageDistance));
        }

        private float calcAverageDistance()
        {
            return this.averageDistance / Planet.SCALE_AVERAGE_DISTANCE;
        }

        private RectangleF calcRect(PointF center, float radius)
        {
            return new RectangleF(center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
        }

        private void drawPlanet(Graphics graphics, Brush brush, PointF centerPoint, float calcAverageDistance)
        {
            PointF center = this.planetCenterPosition(centerPoint, calcAverageDistance);
            float calcRadius = this.calcRadius();
            graphics.FillEllipse(brush, this.calcRect(center, calcRadius));
        }

        private PointF planetCenterPosition(PointF centerPoint, float radius)
        {
            double position = this.positionInRad();
            return new PointF((float)(centerPoint.X + Math.Sin(position) * radius), (float)(centerPoint.Y - Math.Cos(position) * radius));
        }

        private float calcRadius()
        {
            return this.radius / Planet.SCALE_RADIUS;
        }

        private double positionInRad()
        {
            return this.position * 2 * Math.PI / 360;
        }

        public void simulateDays( int days )
        {
            this.position += days * 360 / (float)this.orbitalPeriodInDays;
        }

        public static Planet parse(String line)
        {
            try
            {
                string[] lineItem = line.Split(Planet.DELIMITER);
                return new Planet(lineItem[0], 
                    Convert.ToSingle(lineItem[1]), 
                    Convert.ToInt32(lineItem[2]), 
                    Convert.ToSingle(lineItem[3]), 
                    Convert.ToSingle(lineItem[4]));
            }
            catch (Exception e)
            {
                throw new PlanetParseException("Planet parse error.", line, e);
            }
        } 

        public override string ToString()
        {
            StringBuilder info = new StringBuilder(100);
            info.Append("---=== ").Append(this.name).Append(" ===---\n");
            info.Append("Average distance: ").Append(this.averageDistance).Append("\n");
            info.Append("Orbital period in days: ").Append(this.orbitalPeriodInDays).Append("\n");
            info.Append("Current position: ").Append(this.position).Append("\n");
            info.Append("Radius: ").Append(this.radius).Append("\n");
            return info.ToString();
        }

    }
}
