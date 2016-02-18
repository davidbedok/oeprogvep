using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QTetris
{
    public partial class NewHighScoreForm : Form
    {

        private LevelItem startLevel;
        private int points;

        public NewHighScoreForm()
        {
            InitializeComponent();
        }

        public LevelItem StartLevel
        {
            set
            {
                startLevel = value;
                lStartLevel.Text = startLevel.ToString();
            }
        }

        public int Points
        {
            set { 
                this.points = value;
                lPoints.Text = points.ToString();
            }
        }

        public HighScoreItem SavedItem
        {
            get { return new HighScoreItem(tbPlayerName.Text, points, startLevel); }
        }

    }
}
