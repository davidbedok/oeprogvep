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
        private Points[] iPoints;
        private Edges[] iEdges;
        private const int imgX = 400;
        private const int imgY = 300;


        public GraphForm()
        {
            InitializeComponent();
            pbCanvas.Image = new Bitmap(GraphForm.imgX, GraphForm.imgY);
            pbCanvas.SizeMode = PictureBoxSizeMode.StretchImage;
            Clear();
        }

        private void Clear()
        {
            Graphics g = Graphics.FromImage(pbCanvas.Image);
            g.Clear(Color.White);
            g.DrawRectangle(Pens.Black, 0, 0, GraphForm.imgX - 2, GraphForm.imgY-2);
            pbCanvas.Refresh();
        }

        private void FillComboBox()
        {
            cbPointA.Items.Clear();
            cbPointB.Items.Clear();
            cbEdges.Items.Clear();
            for (int i = 0; i < Points.numberOfPoints; i++)
            {
                cbPointA.Items.Add(iPoints[i]);
                cbPointB.Items.Add(iPoints[i]);
            }
            for (int i = 0; i < Edges.numberOfEdges; i++)
            {
                cbEdges.Items.Add(iEdges[i]);                
            }
            if (Points.numberOfPoints > 0)
            {
                cbPointA.SelectedIndex = 0;
                cbPointB.SelectedIndex = 0;
            }
            if (Edges.numberOfEdges > 0)
            {
                cbEdges.SelectedIndex = 0;                
            }
        }

        private int getPointsById( int id )
        {
            for (int i = 0; i < Points.numberOfPoints; i++)
            {
                if (iPoints[i].Pid == id)
                {
                    return i;
                }
            }
            return -1;
        }


        private void DrawGraph()
        {
            Clear();
            Graphics g = Graphics.FromImage(pbCanvas.Image);
            Brush iBrush = new SolidBrush(Color.FromArgb(255,0,0,0));
            Pen iPen = new Pen(Color.FromArgb(255,0,0,0));
            for (int i = 0; i < Points.numberOfPoints; i++)
            {
                iBrush = new SolidBrush(iPoints[i].Pcolor);
                g.FillEllipse(iBrush, 
                    (float)(iPoints[i].PposX - iPoints[i].Pradius),
                    (float)(iPoints[i].PposY - iPoints[i].Pradius),
                    (float)(iPoints[i].Pradius * 2),
                    (float)(iPoints[i].Pradius * 2));
                g.DrawString(iPoints[i].Pname, SystemFonts.DefaultFont, iBrush,
                    (float)(iPoints[i].PposX - iPoints[i].Pradius) - 20,
                    (float)(iPoints[i].PposY - iPoints[i].Pradius) + 10);
            }

            int pA = -1;
            int pB = -1;
            for (int i = 0; i < Edges.numberOfEdges; i++)
            {
                iPen.Width = (float)iEdges[i].PpenWidth;
                pA = getPointsById(iEdges[i].PpointAid);
                pB = getPointsById(iEdges[i].PpointBid);
                g.DrawLine(iPen,
                    (float)iPoints[pA].PposX,
                    (float)iPoints[pA].PposY,
                    (float)iPoints[pB].PposX,
                    (float)iPoints[pB].PposY);                
            }
            pbCanvas.Refresh();
        }

        private void bOpenPoints_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Points files|points*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK){
                iPoints = Points.LoadFromFile(openFileDialog1.FileName);
            }
            FillComboBox();
        }

        private void bOpenEdges_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Points files|edges*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                iEdges = Edges.LoadFromFile(openFileDialog1.FileName);
            }
            FillComboBox();
        }

        private void bDraw_Click(object sender, EventArgs e)
        {
            DrawGraph();
        }

        private void bAddEdge_Click(object sender, EventArgs e)
        {
            int pAid = ((Points)(cbPointA.Items[cbPointA.SelectedIndex])).Pid;
            int pBid = ((Points)(cbPointA.Items[cbPointB.SelectedIndex])).Pid;
            iEdges[Edges.numberOfEdges] = new Edges(pAid,pBid,2);
            FillComboBox();
            DrawGraph();
        }
    }
}
