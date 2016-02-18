using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApplication15
{
    class LabirintusRajzKonverter : IValueConverter
    {
        public const int negyzetMeret = 20;

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
                bool[,] helyek = (bool[,])value;
                GeometryGroup palya = new GeometryGroup();
                for (int i = 0; i < Labirintus.labirintusY; i++)
                {
                    for (int j = 0; j < Labirintus.labirintusX; j++)
                    {
                        if (helyek[i, j])
                        {
                            RectangleGeometry geo = new RectangleGeometry(new Rect(j * negyzetMeret, i * negyzetMeret, negyzetMeret, negyzetMeret));
                            palya.Children.Add(geo);
                        }
                    }
                }
                return palya;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
