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
        private GraphHolder holder;
        private const int IMG_X = 400;
        private const int IMG_Y = 300;

        public GraphForm()
        {
            InitializeComponent();
            pbCanvas.Image = new Bitmap(GraphForm.IMG_X, GraphForm.IMG_Y);
            pbCanvas.SizeMode = PictureBoxSizeMode.StretchImage;
            Clear();
            this.holder = new GraphHolder();
        }

        private void Clear()
        {
            Graphics g = Graphics.FromImage(pbCanvas.Image);
            g.Clear(Color.White);
            g.DrawRectangle(Pens.Black, 0, 0, GraphForm.IMG_X - 2, GraphForm.IMG_Y-2);
            pbCanvas.Refresh();
        }

        private void FillComboBox()
        {
            cbPointA.Items.Clear();
            cbPointB.Items.Clear();
            cbEdges.Items.Clear();
            for (int i = 0; i < this.holder.NumberOfPoints; i++)
            {
                cbPointA.Items.Add(this.holder.Points[i]);
                cbPointB.Items.Add(this.holder.Points[i]);
            }
            for (int i = 0; i < this.holder.NumberOfEdges; i++)
            {
                // cbEdges.Items.Add(this.holder.Edges[i]); 
                cbEdges.Items.Add(this.holder.UpgradeEdges[i]);
            }
            if (this.holder.NumberOfPoints > 0)
            {
                cbPointA.SelectedIndex = 0;
                cbPointB.SelectedIndex = 0;
            }
            if (this.holder.NumberOfEdges > 0)
            {
                cbEdges.SelectedIndex = 0;                
            }
        }

        private void DrawGraph()
        {
            Clear();
            Graphics g = Graphics.FromImage(pbCanvas.Image);
            Brush iBrush = new SolidBrush(Color.FromArgb(255,0,0,0));
            Pen iPen = new Pen(Color.FromArgb(255,0,0,0));
            for (int i = 0; i < this.holder.NumberOfPoints; i++)
            {
                iBrush = new SolidBrush(this.holder.Points[i].PointColor);
                g.FillEllipse(iBrush,
                    (this.holder.Points[i].PosX - this.holder.Points[i].Radius),
                    (this.holder.Points[i].PosY - this.holder.Points[i].Radius),
                    (this.holder.Points[i].Radius * 2),
                    (this.holder.Points[i].Radius * 2));
                g.DrawString(this.holder.Points[i].Name, SystemFonts.DefaultFont, iBrush,
                    (this.holder.Points[i].PosX - this.holder.Points[i].Radius) - 20,
                    (this.holder.Points[i].PosY - this.holder.Points[i].Radius) + 10);
            }

            int pA = -1;
            int pB = -1;
            for (int i = 0; i < this.holder.NumberOfEdges; i++)
            {
                iPen.Width = this.holder.Edges[i].PenWidth;
                pA = this.holder.getPointIndexById(this.holder.Edges[i].StartPointId);
                pB = this.holder.getPointIndexById(this.holder.Edges[i].EndPointId);
                g.DrawLine(iPen,
                    this.holder.Points[pA].PosX,
                    this.holder.Points[pA].PosY,
                    this.holder.Points[pB].PosX,
                    this.holder.Points[pB].PosY);                
            }
            pbCanvas.Refresh();
        }

        private void DrawUpgradeGraph()
        {
            Clear();
            Graphics g = Graphics.FromImage(pbCanvas.Image);
            Brush iBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
            Pen iPen = new Pen(Color.FromArgb(255, 0, 0, 0));
            for (int i = 0; i < this.holder.NumberOfPoints; i++)
            {
                iBrush = new SolidBrush(this.holder.Points[i].PointColor);
                g.FillEllipse(iBrush,
                    (this.holder.Points[i].PosX - this.holder.Points[i].Radius),
                    (this.holder.Points[i].PosY - this.holder.Points[i].Radius),
                    (this.holder.Points[i].Radius * 2),
                    (this.holder.Points[i].Radius * 2));
                g.DrawString(this.holder.Points[i].Name, SystemFonts.DefaultFont, iBrush,
                    (this.holder.Points[i].PosX - this.holder.Points[i].Radius) - 20,
                    (this.holder.Points[i].PosY - this.holder.Points[i].Radius) + 10);
            }

            for (int i = 0; i < this.holder.NumberOfEdges; i++)
            {
                iPen.Width = this.holder.UpgradeEdges[i].PenWidth;
                g.DrawLine(iPen,
                    this.holder.UpgradeEdges[i].StartPoint.PosX,
                    this.holder.UpgradeEdges[i].StartPoint.PosY,
                    this.holder.UpgradeEdges[i].EndPoint.PosX,
                    this.holder.UpgradeEdges[i].EndPoint.PosY);
            }
            pbCanvas.Refresh();
        }

        private void bOpenPoints_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Points files|points*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK){
                this.holder.LoadFromPointsFile(openFileDialog1.FileName);
            }
            this.FillComboBox();
        }

        private void bOpenEdges_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Points files|edges*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // this.holder.LoadFromEdgesFile(openFileDialog1.FileName);
                this.holder.LoadFromUpgradeEdgesFile(openFileDialog1.FileName);
            }
            this.FillComboBox();
        }

        private void bDraw_Click(object sender, EventArgs e)
        {
            // DrawGraph();
            DrawUpgradeGraph();
        }

        private void bAddEdge_Click(object sender, EventArgs e)
        {
            int pAid = ((Point)(cbPointA.Items[cbPointA.SelectedIndex])).Id;
            int pBid = ((Point)(cbPointA.Items[cbPointB.SelectedIndex])).Id;
            this.holder.Edges[this.holder.NumberOfEdges] = new Edge(pAid, pBid, 2);
            FillComboBox();
            DrawGraph();
        }
    }
}
