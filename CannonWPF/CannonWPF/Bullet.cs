using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CannonWPF
{
    public class Bullet
    {
        private const double RADIUS = 10;

        private readonly double angle;
        private Point position;

        public Bullet(Point position, double angle)
        {
            this.position = position;
            this.angle = angle;
        }


    }
}
