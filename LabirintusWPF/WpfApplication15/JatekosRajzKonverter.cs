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
    class JatekosRajzKonverter : IValueConverter
    {
        public const int negyzetMeret = 20;

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Point jatekosPont = (Point)value;
            return new EllipseGeometry(new Rect(jatekosPont.X * negyzetMeret, jatekosPont.Y * negyzetMeret, negyzetMeret, negyzetMeret));
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
