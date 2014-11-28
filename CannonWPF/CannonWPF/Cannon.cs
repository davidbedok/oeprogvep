using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CannonWPF
{
    public class Cannon : INotifyPropertyChanged
    {

        private readonly Point origo;
        private readonly double length;
        private double angle;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Angle
        {
            get
            {
                return this.angle * Math.PI / 180;
            }
            set
            {
                this.angle += value * Math.PI / 180;
                this.onPropertyChanged("EndX");
                this.onPropertyChanged("EndY");
            }
        }

        public double EndX
        {
            get
            {
                return this.origo.X + Math.Cos(this.angle) * this.length;
            }
        }

        public double EndY
        {
            get
            {
                return this.origo.Y - Math.Sin(this.angle) * this.length;
            }
        }

        public Cannon(double x, double y, double length)
            : this(new Point(x, y), length)
        {
        }

        public Cannon(Point origo, double length)
        {
            this.origo = origo;
            this.length = length;
            this.angle = Math.PI;
        }
        protected void onPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Line build()
        {
            Line line = new Line();
            line.X1 = this.origo.X;
            line.Y1 = this.origo.Y;

            line.Stroke = Brushes.Black;
            line.StrokeThickness = 20;
            line.StrokeEndLineCap = PenLineCap.Triangle;

            line.X2 = this.EndX;
            Binding lineX2Binding = new Binding("EndX");
            lineX2Binding.Source = this;
            line.SetBinding(Line.X2Property, lineX2Binding);

            line.Y2 = this.EndY;
            Binding lineY2Binding = new Binding("EndY");
            lineY2Binding.Source = this;
            line.SetBinding(Line.Y2Property, lineY2Binding);

            return line;
        }

    }
}
