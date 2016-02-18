using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SolarSystemWPF
{

    public class Planet : INotifyPropertyChanged
    {
        private const char DELIMITER = ';';
        private const double CHAR_WIDTH = 8;

        private readonly string name;
        private readonly double distance;
        private readonly int timeInEarthDay;
        private double angle;
        private readonly double radius;
        private readonly SolarSystem system;
        private readonly Brush brush;

        public event PropertyChangedEventHandler PropertyChanged;

        public String Name
        {
            get { return this.name; }
        }

        public double Distance
        {
            get { return this.distance; }
        }

        public int TimeInEarthDay
        {
            get { return this.timeInEarthDay; }
        }

        private double CalculatedDistance
        {
            get { return this.system.calculateDistance(this.distance); }
        }

        public double OriginalRadius
        {
            get { return this.radius; }
        }

        private double Radius
        {
            get { return this.radius / 3000; }
        }

        private double Diameter
        {
            get { return this.Radius * 2; }
        }

        public double Angle
        {
            get { return this.angle; }
        }

        private double AngleInRadian
        {
            get { return this.angle * Math.PI / 180; }
        }

        public double PlanetRectLeft
        {
            get { return this.system.Star.X + Math.Sin(this.AngleInRadian) * this.CalculatedDistance - this.Radius; }
        }

        public double PlanetRectTop
        {
            get { return this.system.Star.Y - Math.Cos(this.AngleInRadian) * this.CalculatedDistance - this.Radius; }
        }

        public double MetaLabelX
        {
            get { return this.PlanetRectLeft + this.Radius - (this.name.Length / 2) * Planet.CHAR_WIDTH; }
        }

        public double MetaLabelY
        {
            get { return this.PlanetRectTop + this.Diameter; }
        }

        public Planet(string name, double distance, int timeInEarthDay, double angle, double radius, byte red, byte green, byte blue, SolarSystem system)
        {
            this.name = name;
            this.distance = distance;
            this.timeInEarthDay = timeInEarthDay;
            this.angle = angle;
            this.radius = radius;
            this.system = system;
            this.brush = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }

        public void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Drawing drawOrbit()
        {
            GeometryDrawing drawing = new GeometryDrawing();
            drawing.Pen = new Pen(Brushes.Gray, 1);
            drawing.Pen.DashStyle = DashStyles.Dot;
            drawing.Geometry = new EllipseGeometry(this.system.Star, this.CalculatedDistance, this.CalculatedDistance);
            return drawing;
        }

        public Ellipse buildPlanet()
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = this.Radius * 2;
            ellipse.Height = this.Radius * 2;
            ellipse.Fill = this.brush;

            Binding xBinding = new Binding("PlanetRectLeft");
            xBinding.Source = this;
            ellipse.SetBinding(Canvas.LeftProperty, xBinding);

            Binding yBinding = new Binding("PlanetRectTop");
            yBinding.Source = this;
            ellipse.SetBinding(Canvas.TopProperty, yBinding);

            ellipse.MouseDown += ellipse_MouseDown;
            return ellipse;
        }

        public Label buildMeta()
        {
            Label label = null;
            if (this.CalculatedDistance > 50)
            {
                label = new Label();
                label.Content = this.name;

                Binding xBinding = new Binding("MetaLabelX");
                xBinding.Source = this;
                label.SetBinding(Canvas.LeftProperty, xBinding);

                Binding yBinding = new Binding("MetaLabelY");
                yBinding.Source = this;
                label.SetBinding(Canvas.TopProperty, yBinding);
            }
            return label;
        }

        private void ellipse_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            PlanetDetails details = new PlanetDetails();
            details.Planet = this;
            details.ShowDialog();
        }

        public void time(int numberOfEarthDay)
        {
            this.changeAngle(numberOfEarthDay);
            OnPropertyChanged("PlanetRectLeft");
            OnPropertyChanged("PlanetRectTop");
            OnPropertyChanged("MetaLabelX");
            OnPropertyChanged("MetaLabelY");
        }

        private void changeAngle(int numberOfEarthDay)
        {
            this.angle += 360 / (double)this.timeInEarthDay * numberOfEarthDay;
            if (this.angle > 360)
            {
                this.angle -= 360;
            }
        }

        public static Planet parse(SolarSystem system, String line)
        {
            String[] items = line.Split(Planet.DELIMITER);
            String name = items[0];
            double distance = Double.Parse(items[1]);
            int timeInEarthDay = Int32.Parse(items[2]);
            double angle = Double.Parse(items[3]);
            double radius = Double.Parse(items[4]);
            byte red = Byte.Parse(items[5]);
            byte green = Byte.Parse(items[6]);
            byte blue = Byte.Parse(items[7]);
            return new Planet(name, distance, timeInEarthDay, angle, radius, red, green, blue, system);
        }

    }
}
