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
        private readonly string name;
        private readonly double distance;
        private readonly int timeInEarthDay;
        private double angle;
        private readonly double radius;
        private readonly SolarSystem system;
        
        public event PropertyChangedEventHandler PropertyChanged;

        public String Name
        {
            get { return this.name; }
        }

        public double Distance
        {
            get { return this.distance; }
        }

        private double CalculatedDistance
        {
            get { return this.system.calculateDistance(this.distance); }
        }

        private double Radius
        {
            get { return this.radius / 3000; }
        }

        public void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private double AngleInRadian
        {
            get { return this.angle * Math.PI / 180; }
        }

        public double PlanetX
        {
            get { return this.system.Star.X + Math.Sin(this.AngleInRadian) * this.CalculatedDistance - this.Radius; }
        }

        public double PlanetY
        {
            get { return this.system.Star.Y - Math.Cos(this.AngleInRadian) * this.CalculatedDistance - this.Radius; }
        }

        public double MetaX
        {
            get { return this.PlanetX + 10; }
        }

        public double MetaY
        {
            get { return this.PlanetY + 10; }
        }

        public Planet(string name, double distance, int timeInEarthDay, double angle, double radius, SolarSystem system )
        {
            this.name = name;
            this.distance = distance;
            this.timeInEarthDay = timeInEarthDay;
            this.angle = angle;
            this.radius = radius;
            this.system = system;
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
            ellipse.Fill = Brushes.MidnightBlue;

            Binding xBinding = new Binding("PlanetX");
            xBinding.Source = this;
            ellipse.SetBinding(Canvas.LeftProperty, xBinding);

            Binding yBinding = new Binding("PlanetY");
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

                Binding xBinding = new Binding("MetaX");
                xBinding.Source = this;
                label.SetBinding(Canvas.LeftProperty, xBinding);

                Binding yBinding = new Binding("MetaY");
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
            this.angle += 360 / (double)this.timeInEarthDay * numberOfEarthDay;

            if (this.angle > 360)
                this.angle -= 360;

            OnPropertyChanged("PlanetX");
            OnPropertyChanged("PlanetY");
            OnPropertyChanged("MetaX");
            OnPropertyChanged("MetaY");
        }

    }
}
