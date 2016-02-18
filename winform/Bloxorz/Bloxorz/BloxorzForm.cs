using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Bloxorz
{
    public partial class BloxorzForm : Form
    {
        private const string DIR_OF_LEVELS = "levels";
        private const float UNIT = 40;
        private const bool WITH_NEIGHBORS = true;

        private const int TERRAIN_WIDTH = 640;
        private const int TERRAIN_HEIGHT = 640;

        private KeyMessageFilter kmf;

        private Terrain currentTerrain;

        public BloxorzForm()
        {
            InitializeComponent();
            this.loadTerrains();

            kmf = new KeyMessageFilter();
            Application.AddMessageFilter(kmf);
            kmf.keyPressed += new CustomKeyHandler(kmf_keyPressed);
        }

        private void kmf_keyPressed(Move move)
        {
            if (this.currentTerrain != null)
            {
                Graphics g = Graphics.FromImage(this.pbTerrain.Image);
                this.currentTerrain.eraseBlock(g, BloxorzForm.UNIT, BloxorzForm.WITH_NEIGHBORS);
                List<Tuple<Block, Move>> neighbors = this.currentTerrain.Block.legalNeighbors(this.currentTerrain);
                if (neighbors != null)
                {
                    switch (move)
                    {
                        case Bloxorz.Move.Left:
                            if ( this.hasMove(neighbors, Bloxorz.Move.Left) )
                            {
                                this.currentTerrain.Block = this.currentTerrain.Block.left();
                            }
                            break;
                        case Bloxorz.Move.Right:
                            if (this.hasMove(neighbors, Bloxorz.Move.Right))
                            {
                                this.currentTerrain.Block = this.currentTerrain.Block.right();
                            }
                            break;
                        case Bloxorz.Move.Up:
                            if (this.hasMove(neighbors, Bloxorz.Move.Up))
                            {
                                this.currentTerrain.Block = this.currentTerrain.Block.up();
                            }
                            break;
                        case Bloxorz.Move.Down:
                            if (this.hasMove(neighbors, Bloxorz.Move.Down))
                            {
                                this.currentTerrain.Block = this.currentTerrain.Block.down();
                            }
                            break;
                    }
                }
                this.currentTerrain.drawBlock(g, BloxorzForm.UNIT, BloxorzForm.WITH_NEIGHBORS);
                this.pbTerrain.Invalidate();
                if (this.currentTerrain.check())
                {
                    MessageBox.Show("Level Complete!");
                }
            }
        }

        private bool hasMove(List<Tuple<Block, Move>> neighbors, Move move)
        {
            bool result = false;
            foreach (Tuple<Block, Move> pair in neighbors) {
                if (move == pair.Item2)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private void initTerrain()
        {
            this.pbTerrain.Image = new Bitmap(BloxorzForm.TERRAIN_WIDTH, BloxorzForm.TERRAIN_HEIGHT);
            this.pbTerrain.SizeMode = PictureBoxSizeMode.StretchImage;
            Graphics g = Graphics.FromImage(this.pbTerrain.Image);
            g.Clear(Color.White);
            if (this.currentTerrain != null)
            {
                this.currentTerrain.draw(g, BloxorzForm.UNIT);
                this.currentTerrain.drawBlock(g, BloxorzForm.UNIT, BloxorzForm.WITH_NEIGHBORS);
            }
        }

        private void loadTerrains()
        {
            string[] files = Directory.GetFiles(BloxorzForm.DIR_OF_LEVELS);
            foreach (string file in files)
            {
                try
                {
                    lbLevels.Items.Add(Terrain.loadTerrain(file));
                } catch (InvalidMapFileException e) {
                    lbErrors.Items.Add(e);
                }
            }
            if (lbLevels.Items.Count > 0)
            {
                this.lbLevels.SelectedIndex = 0;
                this.currentTerrain = (Terrain)lbLevels.SelectedItem;
                this.initTerrain();
            }
            else
            {
                MessageBox.Show("No level found (dir: " + BloxorzForm .DIR_OF_LEVELS+ ")");
            }
        }

        private void lbLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( ( this.lbLevels.SelectedItem != null ) && ( this.lbLevels.SelectedItem is Terrain ) )
            {
                this.currentTerrain = (Terrain) this.lbLevels.SelectedItem;
                this.currentTerrain.reStart();
                this.initTerrain();
            }
        }

    }
}
