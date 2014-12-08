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
        private readonly int distance;
        private readonly int timeInEarthDay;
        private double angle; // tárolás szögben, visszaadás radiánban
        private readonly double radius;
        private readonly Point starPosition;
        //private double xpozicio, ypozicio; EZT NEM SZABAD

        public event PropertyChangedEventHandler PropertyChanged;

        public String Name
        {
            get { return this.name; }
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

        public double XPozicio
        {
            get { return this.starPosition.X + Math.Sin(this.AngleInRadian) * this.distance; }
        }

        public double YPozicio
        {
            get { return this.starPosition.Y - Math.Cos(this.AngleInRadian) * this.distance; }
        }

        public double XPozicioMeta
        {
            get { return this.XPozicio + 10; }
        }

        public double YPozicioMeta
        {
            get { return this.YPozicio + 10; }
        }

        public Planet(string name, int distance, int timeInEarthDay, double angle, double radius, Point starPosition)
        {
            this.name = name;
            // a 10-es osztoszamnak a a max tavolsagtol kell fuggnie
            // max width: 600
            // szukseges: 4497 * 2
            // 4497-et 300-as aranyra kell szukiteni..
            this.distance = distance / 10;
            this.timeInEarthDay = timeInEarthDay;
            this.angle = angle;
            this.radius = radius;
            this.starPosition = starPosition;
        }
        public Drawing getOrbit()
        {
            GeometryDrawing drawing = new GeometryDrawing();
            drawing.Pen = new Pen(Brushes.Black, 1);
            drawing.Geometry = this.buildOrbit();
            return drawing;
        }

        private Geometry buildOrbit()
        {
            return new EllipseGeometry(this.starPosition, this.distance, this.distance);
        }

        public Ellipse buildPlanet()
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = (this.radius * 2) / 3000;
            ellipse.Height = (this.radius * 2) / 3000;
            ellipse.Fill = Brushes.MidnightBlue;

            Binding xBinding = new Binding("XPozicio");
            xBinding.Source = this;
            ellipse.SetBinding(Canvas.LeftProperty, xBinding);

            Binding yBinding = new Binding("YPozicio");
            yBinding.Source = this;
            ellipse.SetBinding(Canvas.TopProperty, yBinding);

            ellipse.MouseDown += ellipse_MouseDown;

            return ellipse;
        }

        public Label buildMeta()
        {
            Label label = new Label();
            label.Content = this.name;

            Binding xBinding = new Binding("XPozicioMeta");
            xBinding.Source = this;
            label.SetBinding(Canvas.LeftProperty, xBinding);

            Binding yBinding = new Binding("YPozicioMeta");
            yBinding.Source = this;
            label.SetBinding(Canvas.TopProperty, yBinding);

            return label;
        }

        private void ellipse_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            PlanetDetails details = new PlanetDetails();
            details.Planet = this;
            details.ShowDialog();
        }

        public void Move(int numberOfEarthDay)
        {
            this.angle += 360 / (double)this.timeInEarthDay * numberOfEarthDay;

            if (this.angle > 360)
                this.angle -= 360;

            OnPropertyChanged("XPozicio");
            OnPropertyChanged("YPozicio");
            OnPropertyChanged("XPozicioMeta");
            OnPropertyChanged("YPozicioMeta");
        }

    }
}
