using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace SolarSystemWPF
{
    public class SolarSystem
    {
        private const double SUN_RADIUS = 2;

        private readonly Point star;
        private readonly List<Planet> planets;
        private double maximumPlanetDistance;

        public List<Planet> Planets
        {
            get { return this.planets; }
        }

        public Point Star
        {
            get { return this.star; }
        }

        private Rect Frame
        {
            get { return new Rect(0, 0, this.star.X * 2, this.star.Y * 2); }
        }

        public SolarSystem(double starX, double starY)
        {
            this.star = new Point(starX, starY);
            this.planets = new List<Planet>();
            this.maximumPlanetDistance = 0;
        }

        public double calculateDistance(double planetDistance)
        {
            return planetDistance / this.maximumPlanetDistance * this.star.X;
        }

        private void add(Planet planet)
        {
            this.planets.Add(planet);
            if (planet.Distance > this.maximumPlanetDistance)
            {
                this.maximumPlanetDistance = planet.Distance;
            }
        }

        public void time(int numberOfEarthDay)
        {
            foreach (Planet planet in this.planets)
            {
                planet.time(numberOfEarthDay);
            }
        }

        public DrawingImage drawOrbits()
        {
            return new DrawingImage(this.buildDrawing());
        }

        private Drawing buildDrawing()
        {
            DrawingGroup group = new DrawingGroup();
            group.Children.Add(this.drawFrame());
            group.Children.Add(this.drawStar());
            foreach (Planet planet in this.planets)
            {
                group.Children.Add(planet.drawOrbit());
            }
            return group;
        }

        private Drawing drawFrame()
        {
            GeometryDrawing drawing = new GeometryDrawing();
            drawing.Pen = new Pen(Brushes.Gray, 1);
            drawing.Geometry = new RectangleGeometry(this.Frame);
            return drawing;
        }

        private Drawing drawStar()
        {
            GeometryDrawing drawing = new GeometryDrawing();
            drawing.Pen = new Pen(Brushes.Yellow, 1);
            drawing.Brush = Brushes.Yellow;
            drawing.Geometry = new EllipseGeometry(this.star, SolarSystem.SUN_RADIUS, SolarSystem.SUN_RADIUS);
            return drawing;
        }

        public static SolarSystem parse(String fileName, double systemX, double systemY)
        {
            SolarSystem result = new SolarSystem(systemX / 2, systemY / 2);
            StreamReader reader = new StreamReader(fileName);
            while (!reader.EndOfStream)
            {
                result.add(Planet.parse(result, reader.ReadLine()));
            }
            return result;
        }

    }
}
