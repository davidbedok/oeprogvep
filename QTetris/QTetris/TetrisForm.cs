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
  
    public partial class TetrisForm : Form
    {
        public const int MAP_X = 200;
        public const int MAP_Y = 400;

        public const int FALLITEM_X = 100;
        public const int FALLITEM_Y = 100;

        private Tetris tetris;
        private Random rand;

        private KeyMessageFilter kmf;

        private HighScore highScore;

        public TetrisForm()
        {
            InitializeComponent();
            rand = new Random();
        }

        private void TetrisForm_Load(object sender, EventArgs e)
        {
            pbTetrisMap.Image = new Bitmap(TetrisForm.MAP_X, TetrisForm.MAP_Y);
            pbTetrisMap.SizeMode = PictureBoxSizeMode.StretchImage;

            pbFallItem.Image = new Bitmap(TetrisForm.FALLITEM_X, TetrisForm.FALLITEM_Y);
            pbFallItem.SizeMode = PictureBoxSizeMode.StretchImage;

            Level.initLevel();
            for (int i = 0; i < Level.MAX_LEVEL; i++)
            {
                cbLevel.Items.Add(Level.levelItems[i]);
            }
            if (cbLevel.Items.Count > 0)
            {
                cbLevel.SelectedIndex = 0;
            }
            
            kmf = new KeyMessageFilter();
            Application.AddMessageFilter(kmf);

            highScore = HighScore.loadHighScore(HighScore.HIGH_SCORE_FILE_NAME);

            this.initHighScore();           

            initTetrisMap();
        }

        private void initHighScore()
        {
            lbHighScore.Items.Clear();
            foreach (KeyValuePair<int, HighScoreItem> hsi in highScore.HighScores)
            {
                lbHighScore.Items.Insert(0, hsi.Value);
                // lbHighScore.Items.Add(hsi.Value);
            }
        }

        private void initTetrisMap()
        {
            Graphics g = Graphics.FromImage(pbTetrisMap.Image);
            g.Clear(Color.White);
            g.DrawRectangle(Pens.Black, 0, 0, TetrisForm.MAP_X - 1, TetrisForm.MAP_Y - 1);
            pbTetrisMap.Refresh();
        }

        private void initFallItem()
        {
            Graphics g = Graphics.FromImage(pbFallItem.Image);
            g.Clear(Color.White);
            g.DrawRectangle(Pens.Black, 0, 0, TetrisForm.FALLITEM_X - 1, TetrisForm.FALLITEM_Y - 1);
            pbFallItem.Refresh();
        }

        private void controlGUI( bool value )
        {
            tbMapX.Enabled = value;
            tbMapY.Enabled = value;
            cbLevel.Enabled = value;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            tetris = new Tetris(Convert.ToInt32(tbMapX.Text), Convert.ToInt32(tbMapY.Text), TetrisForm.MAP_X, TetrisForm.MAP_Y, ((LevelItem)cbLevel.Items[cbLevel.SelectedIndex]));
            tetris.changeLevel += new TetrisNotifyhandler(tetris_changeLevel);
            
            lPoints.Text = tetris.Points.ToString();

            this.controlGUI(false);

            initTetrisMap();
            tetris.draw(Graphics.FromImage(pbTetrisMap.Image));

            timerRefresh.Enabled = true;

            timerFall.Interval = tetris.ActLevelItem.Speed;

            createNewFallItem();

            pbTetrisMap.Refresh();
        }

        void tetris_changeLevel(LevelItem param)
        {
            lLevel.Text = param.Level.ToString();
            tbSpeed.Text = param.Speed.ToString();
            tbPoint.Text = param.Point.ToString();
            timerFall.Interval = param.Speed;
        }

        private void createNewFallItem()
        {
            tetris.createNewFallItem(rand);
            
            initFallItem();
            tetris.drawFallItem(Graphics.FromImage(pbFallItem.Image));
            pbFallItem.Refresh();

            kmf.setTetris(tetris, timerFall);
            timerFall.Interval = tetris.ActLevelItem.Speed;
            timerFall.Enabled = true;            
        }

        private void bFallItem_Click(object sender, EventArgs e)
        {
            createNewFallItem();
        }

        private void timerFall_Tick(object sender, EventArgs e)
        {
            try
            {
                tetris.fall();
            }
            catch (BlockException be)
            {
                System.Console.WriteLine("timerFall_Tick "+be.Message);
                this.block();
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            try
            {
                tetris.draw(Graphics.FromImage(pbTetrisMap.Image));
                if (tetris.IsDraw)
                {
                    pbTetrisMap.Refresh();
                    lPoints.Text = tetris.Points.ToString();
                }
            }
            catch (NotSupportedDrawException be)
            {
                System.Console.WriteLine("NEVER FIRED "+be.Message);
                // MessageBox.Show("Application error","Error");
                this.block();
            }
        }

        private void block()
        {
            timerRefresh.Enabled = false;
            timerFall.Enabled = false;
            try
            {
                tetris.fixItem();
                tetris.IsDraw = true;
                createNewFallItem();
                timerRefresh.Enabled = true;
            }
            catch (EndOfGameException eog)
            {
                System.Console.WriteLine("block "+eog.Message);
                NewHighScoreForm newHighScoreForm = new NewHighScoreForm();
                newHighScoreForm.StartLevel = tetris.StartLevelItem;
                newHighScoreForm.Points = tetris.Points;

                DialogResult dr = newHighScoreForm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    highScore.addHighScoreItem(newHighScoreForm.SavedItem);
                    this.initHighScore(); 
                    highScore.saveHighScore(HighScore.HIGH_SCORE_FILE_NAME);
                }

                this.controlGUI(true);

            }

        }

        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LevelItem selectedLevelItem = (LevelItem)cbLevel.Items[cbLevel.SelectedIndex];
            lLevel.Text = selectedLevelItem.Level.ToString();
            tbSpeed.Text = selectedLevelItem.Speed.ToString();
            tbPoint.Text = selectedLevelItem.Point.ToString();

        }
       
    }
}
