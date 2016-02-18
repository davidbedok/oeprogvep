using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WpfApplication15
{
    class Labirintus : Bindable
    {
        public const int labirintusY = 20;
        public const int labirintusX = 30;
        
        Point vegPont;
        public Point VegPont
        {
            get { return vegPont; }
        }

        Point jatekosPont;
        public Point JatekosPont
        {
            get { return jatekosPont; }
        }

        private bool[,] helyek;
        public bool[,] Helyek
        {
            get { return helyek; }
        }

        public bool Mozgat(int xValtozas, int yValtozas)
        {
            int ujX = (int)jatekosPont.X + xValtozas;
            int ujY = (int)jatekosPont.Y + yValtozas;
            if (ujX >= 0 && ujX < helyek.GetLength(1) && ujY >= 0 && ujY < helyek.GetLength(0)
                && !helyek[ujY, ujX])
            {
                jatekosPont.X = ujX;
                jatekosPont.Y = ujY;
                OnPropertyChanged("JatekosPont");
                if (jatekosPont.X == vegPont.X && jatekosPont.Y == vegPont.Y)
                    return true;
            }
            return false;
        }

        public Labirintus(string fajl)
        {
            helyek = new bool[labirintusY, labirintusX];

            string[] sorok = fajl.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            for (int i = 0; i < labirintusY; i++)
            {
                for (int j = 0; j < labirintusX; j++)
                {
                    helyek[i, j] = sorok[i][j] == '0';
                    if (sorok[i][j] == '2')
                        jatekosPont = new Point(j, i);
                    else if (sorok[i][j] == '3')
                        vegPont = new Point(j, i);
                }
            }
        }
    }
}
