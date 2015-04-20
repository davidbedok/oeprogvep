using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TimerApp
{

    public class Ball : INotifyPropertyChanged
    {
        private const double MIN_RADIUS = 5;
        public const double MAX_RADIUS = 15;
        private const double MIN_SPEED = 5;
        private const double MAX_SPEED = 15;

        private readonly AppFrame frame;
        private readonly Color color;
        private readonly double speed;
        private readonly double radius;

        private Point point;
        private double angle;

        public event PropertyChangedEventHandler PropertyChanged;
        private double Diameter
        {
            get
            {
                return this.radius * 2;
            }
        }

        public double X
        {
            get { return this.point.X; }
            set
            {
                if (value > 0 && value < this.frame.Width - Diameter +1)
                {
                    this.point.X = value;
                    onPropertyChanged("X");
                }
                else
                {
                    this.angle = 2 * Math.PI - this.angle;
                }
            }
        }

        public double Y
        {
            get { return this.point.Y; }
            set
            {
                if (value > 0 && value < this.frame.Height - this.Diameter + 1)
                {
                    this.point.Y = value;
                    onPropertyChanged("Y");
                }
                else
                {
                    this.angle = Math.PI - this.angle;
                }
            }
        }

        public Ball(Color color, Point point, double speed, double radius, AppFrame frame, double angle)
        {
            this.color = color;
            this.frame = frame;
            this.point = point;
            this.speed = speed;
            this.radius = radius;
            this.angle = angle;
        }

        protected void onPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void jump()
        {
            double a = Math.Sin(this.angle) * this.speed;
            double b = Math.Cos(this.angle) * this.speed;
            this.X = (double)(this.X - a);
            this.Y = (double)(this.Y + b);
        }

        public Ellipse getEllipse()
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Fill = new SolidColorBrush(this.color);
            ellipse.Stroke = Brushes.Black;

            Binding ellipseXBinding = new Binding("X");
            ellipseXBinding.Source = this;
            ellipse.SetBinding(Canvas.LeftProperty, ellipseXBinding);

            Binding ellipseYBinding = new Binding("Y");
            ellipseYBinding.Source = this;
            ellipse.SetBinding(Canvas.TopProperty, ellipseYBinding);

            ellipse.Width = this.Diameter;
            ellipse.Height = this.Diameter;

            return ellipse;
        }

        public static Color getRandColor(Random rand)
        {
            return Color.FromRgb((byte)rand.Next(255), (byte)rand.Next(255), (byte)rand.Next(255));
        }

        public static double getRandSpeed(Random rand)
        {
            return BallFactory.getRandDouble(rand, Ball.MIN_SPEED, Ball.MAX_SPEED);
        }

        public static double getRandRadius(Random rand)
        {
            return BallFactory.getRandDouble(rand, Ball.MIN_RADIUS, Ball.MAX_RADIUS);
        }

        public static double getRandAngle(Random rand)
        {
            return BallFactory.getRandDouble(rand, 0, Math.PI * 2);
        }

    }
}
