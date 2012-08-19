using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QTetris
{
    public class Level : System.Object
    {
        public const int MAX_LEVEL = 10;
        public const int MAXIMUM_SPEED_VALUE = 1000;
        public const int SPEED_STEP = 100;
        public const int MINIMUM_POINT_VALUE = 10;
        public const int POINT_STEP = 10;

        public static LevelItem[] levelItems;

        public static void initLevel() {
            levelItems = new LevelItem[Level.MAX_LEVEL];
            for (int i = 0; i < Level.MAX_LEVEL; i++)
            {
                levelItems[i] = new LevelItem(i+1,Level.MAXIMUM_SPEED_VALUE - i * Level.SPEED_STEP, Level.MINIMUM_POINT_VALUE + i * Level.POINT_STEP);
            }
        }

        public static LevelItem getLevelItemById( int level )
        {
            int i = 0;
            bool find = false;
            while ((i < Level.MAX_LEVEL) && (!find))
            {
                if (levelItems[i].Level == level)
                {
                    find = true;
                }
                else
                {
                    i++;
                }
            }
            return levelItems[i];
        }

        public static LevelItem jumpLevel( LevelItem actLevel )
        {
            LevelItem newLevel = actLevel;
            if (actLevel.Level < Level.MAX_LEVEL)
            {
                newLevel = levelItems[actLevel.Level];
            }
            return newLevel;
        }

    }
}
