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
        private const int MIN_RADIUS = 5;
        private const int MAX_RADIUS = 15;
        private const int MIN_SPEED = 5;
        private const int MAX_SPEED = 15;

        private readonly AppFrame frame;
        private readonly Color color;
        private readonly double jumpSpeed;
        private readonly double radius;

        private double x;
        private double y;

        private MoveType xmt;
        private MoveType ymt;

        public event PropertyChangedEventHandler PropertyChanged;

        public double X
        {
            get { return this.x; }
            set
            {
                if (value < this.frame.Width - radius * 2 - 2)
                {
                    if (value > 0)
                    {
                        x = value;
                        onPropertyChanged("X");
                    }
                    else
                    {
                        xmt = MoveType.Down;
                    }
                }
                else
                {
                    xmt = MoveType.Up;
                }
            }
        }

        public double Y
        {
            get { return this.y; }
            set
            {
                if (value < this.frame.Height - radius * 2 - 2)
                {
                    if (value > 0)
                    {
                        y = value;
                        onPropertyChanged("Y");
                    }
                    else
                    {
                        ymt = MoveType.Down;
                    }
                }
                else
                {
                    ymt = MoveType.Up;
                }
            }
        }

        public Ball(Color color, Point point, float jumpSpeed, double radius, AppFrame frame, Direction direction)
        {
            this.color = color;
            this.frame = frame;
            this.x = point.X;
            this.y = point.Y;
            this.jumpSpeed = jumpSpeed;
            this.radius = radius;

            switch (direction)
            {
                case Direction.DOWN:
                    xmt = MoveType.Down;
                    ymt = MoveType.Down;
                    break;
                case Direction.LEFT:
                    xmt = MoveType.Up;
                    ymt = MoveType.Down;
                    break;
                case Direction.RIGHT:
                    xmt = MoveType.Down;
                    ymt = MoveType.Up;
                    break;
                case Direction.UP:
                    xmt = MoveType.Up;
                    ymt = MoveType.Up;
                    break;
            }
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
            if (xmt == MoveType.Down)
            {
                this.X = this.x + this.jumpSpeed;
            }
            else
            {
                this.X = this.x - this.jumpSpeed;
            }
            if (ymt == MoveType.Down)
            {
                this.Y = this.y + this.jumpSpeed;
            }
            else
            {
                this.Y = this.y - this.jumpSpeed;
            }
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

            ellipse.Width = this.radius * 2;
            ellipse.Height = this.radius * 2;

            return ellipse;
        }

        public static Color getRandColor(Random rand)
        {
            return Color.FromRgb((byte)rand.Next(255), (byte)rand.Next(255), (byte)rand.Next(255));
        }

        public static int getRandJumpSpeed(Random rand)
        {
            return rand.Next(Ball.MIN_SPEED, Ball.MAX_SPEED);
        }

        public static int getRandRadius(Random rand)
        {
            return rand.Next(Ball.MIN_RADIUS, Ball.MAX_RADIUS);
        }

    }
}
