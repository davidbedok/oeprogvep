using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace QTetris
{
    public class HighScore : System.Object
    {
        public const string HIGH_SCORE_FILE_NAME = "highscore.dat";

        private SortedList<int,HighScoreItem> highScores;

        public SortedList<int,HighScoreItem> HighScores
        {
            get { return highScores; }
        }

        public HighScore()
        {
            highScores = new SortedList<int,HighScoreItem>();
        }

        public void addHighScoreItem( HighScoreItem highScoreItem )
        {
            highScores.Add(highScoreItem.Points,highScoreItem);
        }

        public void addHighScoreItem( string name, int points, int startLevel )
        {
            highScores.Add(points,new HighScoreItem(name, points, Level.getLevelItemById(startLevel)));
        }

        public static HighScore loadHighScore ( string filename ){
            HighScore highScore = new HighScore();
            string line;
            string[] lineItem;
            try
            {
                StreamReader sr = new StreamReader(File.Open(filename, FileMode.Open));
                line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    lineItem = line.Split(';');
                    highScore.addHighScoreItem(lineItem[0],Convert.ToInt32(lineItem[1]),Convert.ToInt32(lineItem[2]));
                }
                sr.Close();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                System.Windows.Forms.Application.Exit();
            }
            return highScore;
        }

        public void saveHighScore(string filename) {
            HighScore highScore = new HighScore();
            try
            {
                StreamWriter sr = new StreamWriter(File.Open(filename, FileMode.Create));
                foreach (KeyValuePair<int,HighScoreItem> item in highScores)
                {
                    sr.WriteLine(item.Value.printToFile());
                }
                sr.Close();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                System.Windows.Forms.Application.Exit();
            }
        }

    }
}
