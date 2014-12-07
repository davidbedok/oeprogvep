using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    public class SolSystem
    {
        private const double SUN_X = 500;
        private const double SUN_Y = 500;
        
        private List<Planet> planets;

        public List<Planet> Planets
        {
            get { return this.planets; }
        }

        public SolSystem()
        {
            this.planets = new List<Planet>();
        }

        public void add(Planet planet)
        {
            this.planets.Add(planet);
        }

        public void Move( int numberOfEarthDay )
        {
            foreach (Planet p in planets)
            {
                p.Move(numberOfEarthDay);
            }
        }

        public static SolSystem parse(String fileName)
        {
            SolSystem system = new SolSystem();
            StreamReader sr = new StreamReader(fileName);
            string line = "";
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                String[] items = line.Split(';');
                string nev = items[0];
                int naptav = int.Parse(items[1]);
                int keringes = int.Parse(items[2]);
                double akthelyz = double.Parse(items[3]);
                double egyenlsug = double.Parse(items[4]);
                system.add(new Planet(nev, naptav, keringes, akthelyz, egyenlsug, SUN_X, SUN_Y));
            }
            return system;
        }

    }
}
