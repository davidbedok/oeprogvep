using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class StupidForm : Form
    {
        public StupidForm()
        {
            InitializeComponent();
        }

        private void bYES_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YES!!! :-)");
        }

        private void bNO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NO!!!");
        }

        private void bNO_MouseMove(object sender, MouseEventArgs e)
        {
            Point iYesPoint = bYES.Location;
            bYES.Location = bNO.Location;
            bNO.Location = iYesPoint;
        }

        private void bYES_Validated(object sender, EventArgs e)
        {            
            bYES.Focus();
        }
        
    }
}