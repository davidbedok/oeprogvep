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

namespace ShapeBindings
{
    public class Ball : INotifyPropertyChanged
    {
        private double x;
        private double y;

        public event PropertyChangedEventHandler PropertyChanged;

        public double X
        {
            get { return x; }
            set
            {
                x = value;
                this.onPropertyChanged("X");
            }
        }

        public double Y
        {
            get { return y; }
            set
            {
                y = value;
                this.onPropertyChanged("Y");
            }
        }


        public Ball(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void onPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void move()
        {
            X += 5;
            Y += 5;
        }

        public Ellipse getEllipse()
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Fill = Brushes.Red;
            ellipse.Stroke = Brushes.Black;

            Binding ellipseXBinding = new Binding("X");
            ellipseXBinding.Source = this;
            ellipse.SetBinding(Canvas.LeftProperty, ellipseXBinding);

            Binding ellipseYBinding = new Binding("Y");
            ellipseYBinding.Source = this;
            ellipse.SetBinding(Canvas.TopProperty, ellipseYBinding);


            ellipse.Width = 50;
            ellipse.Height = 50;

            return ellipse;
        }

    }
}
