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
        private const double DIAMETER = 15;
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
            this.position = position;
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

        public Ellipse build()
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = DIAMETER;
            ellipse.Height = DIAMETER;

            ellipse.Fill = new SolidColorBrush(Colors.Blue);
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


    }
}
