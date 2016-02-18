using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    public class SolarSystem
    {
        private const float SUN_RADIUS = 3;
        public const int IMG_X = 1000;
        public const int IMG_Y = 1000;

        private readonly List<Planet> planets;

        public SolarSystem()
        {
            this.planets = new List<Planet>();
        }

        public void draw(Graphics graphics, Brush brush)
        {
            PointF centerPoint = this.center();
            graphics.FillEllipse(Brushes.Yellow, this.sunRect(centerPoint));
            foreach (Planet planet in this.planets)
            {
                planet.draw(graphics, centerPoint, brush);
            }
        }

        private RectangleF sunRect(PointF centerPoint)
        {
            float r = SolarSystem.SUN_RADIUS;
            return new RectangleF(centerPoint.X - r, centerPoint.Y - r, 2 * r, 2 * r);
        }

        private PointF center()
        {
            return new PointF((float)SolarSystem.IMG_X / 2, (float)SolarSystem.IMG_Y / 2);
        }

        public void simulateDays( int days )
        {
            foreach (Planet planet in this.planets)
            {
                planet.simulateDays(days);
            }
        }

        public static SolarSystem load( String fileName )
        {
            SolarSystem system = new SolarSystem();
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(File.Open(fileName, FileMode.Open));
                String line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    system.planets.Add(Planet.parse(line));
                }     
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
            return system;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder(300);
            foreach (Planet planet in this.planets)
            {
                info.AppendLine(planet.ToString());
            }
            return info.ToString();
        }

    }
}
