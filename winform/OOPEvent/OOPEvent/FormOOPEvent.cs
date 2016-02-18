using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOPEvent
{
    public partial class FormOOPEvent : Form
    {

        private Test iTest;
 
        public FormOOPEvent()
        {
            InitializeComponent();

            iTest = new Test(this,0);
            iTest.OnValueChange = new TestValueEventHandler();
        }

        private void bSet_Click(object sender, EventArgs e)
        {
            iTest.Value = Convert.ToInt32(this.nudValue.Value);
        }
    }
}
