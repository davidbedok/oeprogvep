using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSGraph
{
    public partial class GraphForm : Form
    {
        private Graph graph;
        private const int IMG_X = 400;
        private const int IMG_Y = 300;

        public GraphForm()
        {
            InitializeComponent();
            this.pbCanvas.Image = new Bitmap(GraphForm.IMG_X, GraphForm.IMG_Y);
            this.pbCanvas.SizeMode = PictureBoxSizeMode.StretchImage;
            this.clear();
            this.graph = new Graph();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void clear()
        {
            Graphics graphics = Graphics.FromImage(pbCanvas.Image);
            graphics.Clear(Color.White);
            graphics.DrawRectangle(Pens.Black, 0, 0, GraphForm.IMG_X - 2, GraphForm.IMG_Y-2);
            this.pbCanvas.Refresh();
        }

        private void fillComboBox()
        {
            this.cbPointA.Items.Clear();
            this.cbPointB.Items.Clear();
            this.cbEdges.Items.Clear();
            this.cbPointA.Items.AddRange(this.graph.Points);
            this.cbPointB.Items.AddRange(this.graph.Points);
            this.cbEdges.Items.AddRange(this.graph.Edges);
        }

        private void draw()
        {
            this.clear();
            this.graph.draw(Graphics.FromImage(pbCanvas.Image));
            this.pbCanvas.Refresh();
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Graph files|graph*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.graph = Graph.load(dialog.FileName);
                } catch ( BadFileFormatException exc ) {
                    MessageBox.Show(exc.ToString());
                }
            }
            this.fillComboBox();
            this.draw();
        }

        private void bDraw_Click(object sender, EventArgs e)
        {
            this.draw();
        }

        private void bAddEdge_Click(object sender, EventArgs e)
        {
            GraphPoint pAid = ((GraphPoint)(cbPointA.Items[cbPointA.SelectedIndex]));
            GraphPoint pBid = ((GraphPoint)(cbPointA.Items[cbPointB.SelectedIndex]));
            this.graph.add(new Edge(pAid, pBid, 2));
            this.fillComboBox();
            this.draw();
        }

    }
}
