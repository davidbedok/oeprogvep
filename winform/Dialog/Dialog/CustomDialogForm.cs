using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dialog
{
    public partial class CustomDialogForm : Form
    {
        public CustomDialogForm()
        {
            InitializeComponent();
        }

        private void MyDialogForm_Load(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
        }

        public string YourName
        {
            get { return this.tbName.Text; }
        }

    }
}