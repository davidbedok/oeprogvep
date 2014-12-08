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

        private void add(string name, double distance, int timeInEarthDay, double angle, double radius)
        {
            this.add(new Planet(name, distance, timeInEarthDay, angle, radius, this));
        }

        public void Move(int numberOfEarthDay)
        {
            foreach (Planet planet in planets)
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
            drawing.Geometry = new EllipseGeometry(this.star, 5, 5);
            return drawing;
        }

        public static SolarSystem parse(String fileName, double systemX, double systemY)
        {
            SolarSystem result = new SolarSystem(systemX / 2, systemY / 2);
            StreamReader sr = new StreamReader(fileName);
            string line = "";
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                String[] items = line.Split(';');
                String name = items[0];
                double distance = Double.Parse(items[1]);
                int timeInEarthDay = Int32.Parse(items[2]);
                double angle = Double.Parse(items[3]);
                double radius = Double.Parse(items[4]);
                result.add(name, distance, timeInEarthDay, angle, radius);
            }
            return result;
        }

    }
}
