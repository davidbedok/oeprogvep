using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QTetris
{
    public class HighScoreItem : System.Object
    {
        private string name;
        private int points;
        private LevelItem startLevel;

        public int Points
        {
            get { return points; }
        }

        public HighScoreItem(string name, int points, LevelItem startLevel)
        {
            this.name = name;
            this.points = points;
            this.startLevel = startLevel;
        }

        public override string ToString()
        {
            return this.name + " : " + this.startLevel + " (" + this.points + ")";
        }

        public string printToFile()
        {
            return this.name + ";" + this.points + ";" + this.startLevel.Level;
        }

    }
}
