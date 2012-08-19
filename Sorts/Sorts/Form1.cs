using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sorts
{
    public partial class SortForm : Form
    {
        private int[] FormArray;

        public SortForm()
        {
            InitializeComponent();
            MySort.sortOrder = SortOrder.Up;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbOriginal.Items.Clear();
            lbExcretory.Items.Clear();
            lbBubbles.Items.Clear();
            lBuborekosCsere.Text = "0";
            lKivalasztasosCsere.Text = "0";

            int maxSize = Convert.ToInt32(nArraySize.Value);
            FormArray = new int[ maxSize ];
            Random rand = new Random();
            for (int i = 0; i < maxSize; i++)
            {
                FormArray[i] = rand.Next(1,1000);
            }
            for (int i = 0; i < maxSize; i++)
            {
                lbOriginal.Items.Add(FormArray[i]);                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res = 0;
            if (FormArray != null)
            {
                lbBubbles.Items.Clear();
                MySort iSort = new MySort(FormArray);
                res = iSort.BubbleSort();
                for (int i = 0; i < lbOriginal.Items.Count; i++)
                {
                    lbBubbles.Items.Add(iSort.FArray[i]);
                }
                lBuborekosCsere.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("Array not exists (create).");
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int res = 0;            
            if (FormArray != null)
            {
                lbExcretory.Items.Clear();
                MySort iSort = new MySort(FormArray);
                res = iSort.MinMaxExcretorySort();
                for (int i = 0; i < lbOriginal.Items.Count; i++)
                {
                    lbExcretory.Items.Add(iSort.FArray[i]);
                }
                lKivalasztasosCsere.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("Array not exists (create).");
            }            
        }

        private void rbUp_CheckedChanged(object sender, EventArgs e)
        {
            MySort.sortOrder = SortOrder.Up;
        }

        private void rbDown_CheckedChanged(object sender, EventArgs e)
        {
            MySort.sortOrder = SortOrder.Down;
        }
    }
}
