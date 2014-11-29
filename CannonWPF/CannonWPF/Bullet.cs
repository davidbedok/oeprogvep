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

namespace CannonWPF
{
    public class Bullet : INotifyPropertyChanged
    {
        private const double RADIUS = 7;
        private const double DIAMETER = RADIUS * 2;
        private const double SPEED = 5;

        private readonly double angle;
        private Point position;

        public event PropertyChangedEventHandler PropertyChanged;

        public double X
        {
            get { return this.position.X; }
            set
            {
               this.position.X = value;
               this.onPropertyChanged("X"); 
            }
        }

        public double Y
        {
            get { return this.position.Y; }
            set
            {
                this.position.Y = value;
                this.onPropertyChanged("Y");   
            }
        }


        public Bullet(Point position, double angle)
        {
            this.position = new Point(position.X - RADIUS, position.Y - RADIUS);
            this.angle = angle;
        }

        public void move()
        {
            this.X = this.X + Math.Sin(this.angle) * SPEED;
            this.Y = this.Y - Math.Cos(this.angle) * SPEED;
        }

        protected void onPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Ellipse build( Random random )
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = DIAMETER;
            ellipse.Height = DIAMETER;

            ellipse.Fill = new SolidColorBrush(createRandomColor(random));
            ellipse.Stroke = Brushes.Black;
            ellipse.StrokeThickness = 1;

            Binding ellipseXBinding = new Binding("X");
            ellipseXBinding.Source = this;
            ellipse.SetBinding(Canvas.LeftProperty, ellipseXBinding);

            Binding ellipseYBinding = new Binding("Y");
            ellipseYBinding.Source = this;
            ellipse.SetBinding(Canvas.TopProperty, ellipseYBinding);

            return ellipse;
        }

        private static Color createRandomColor(Random random)
        {
            return Color.FromRgb((byte)random.Next(255), (byte)random.Next(255), (byte)random.Next(255));
        }


    }
}
