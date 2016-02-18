using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QTetris
{
    public class LevelItem : System.Object
    {
        private int level;
        private int speed;
        private int point;

        public int Level
        {
            get { return level; }
        }

        public int Speed
        {
            get { return speed; }
        }

        public int Point
        {
            get { return point; }
        }

        public LevelItem(int level, int speed, int point)
        {
            this.level = level;
            this.speed = speed;
            this.point = point;
        }

        public override string ToString()
        {
            return "L"+this.level;
        }

    }
}
