using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TimerApp
{
    public enum Direction
    {
        LEFT,
        UP,
        DOWN,
        RIGHT
    }

    public static class DirectionExtensions
    {

        public static Direction randomDirection(Random rand)
        {
            Direction[] enums = (Direction[])Enum.GetValues(typeof(Direction));
            return enums[rand.Next(enums.Length)];
        }

    }

}
