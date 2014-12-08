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

        public List<Planet> Planets
        {
            get { return this.planets; }
        }

        public SolarSystem(double starX, double starY)
        {
            this.star = new Point(starX, starY);
            this.planets = new List<Planet>();
        }

        private void add(Planet planet)
        {
            this.planets.Add(planet);
        }

        private void add(string name, int distance, int timeInEarthDay, double angle, double radius)
        {
            this.add(new Planet(name, distance, timeInEarthDay, angle, radius, this.star));
        }

        public void Move(int numberOfEarthDay)
        {
            foreach (Planet p in planets)
            {
                p.Move(numberOfEarthDay);
            }
        }

        public DrawingImage getOrbits()
        {
            return new DrawingImage(this.buildDrawing());
        }

        private Drawing buildDrawing()
        {
            DrawingGroup group = new DrawingGroup();
            foreach (Planet p in planets)
            {
                group.Children.Add(p.getOrbit());
            }
            return group;
        }

        public static SolarSystem parse(String fileName, double starX, double starY)
        {
            SolarSystem result = new SolarSystem(starX, starY);
            StreamReader sr = new StreamReader(fileName);
            string line = "";
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                String[] items = line.Split(';');
                String name = items[0];
                int distance = Int32.Parse(items[1]);
                int timeInEarthDay = Int32.Parse(items[2]);
                double angle = Double.Parse(items[3]);
                double radius = Double.Parse(items[4]);
                result.add(name, distance, timeInEarthDay, angle, radius);
            }
            return result;
        }

    }
}
