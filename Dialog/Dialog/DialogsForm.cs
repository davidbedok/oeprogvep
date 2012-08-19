using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dialog
{
    public partial class DialogsForm : Form
    {
        public DialogsForm()
        {
            InitializeComponent();
        }

        private void bSimple_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void bHeader_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!", "Hello header");
        }

        private void bUpgrade_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Hello World!", "Caption", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            switch (dialogResult)
            {
                case DialogResult.Yes: MessageBox.Show("Yes"); break;
                case DialogResult.No: MessageBox.Show("No"); break;
                case DialogResult.Cancel: MessageBox.Show("Cancel"); break;
            }
        }

        private void bNoModalCustomDialog_Click(object sender, EventArgs e)
        {
            CustomDialogForm customDialog = new CustomDialogForm();
            customDialog.Show();
        }

        private void bModalCustomDialog_Click(object sender, EventArgs e)
        {
            CustomDialogForm customDialog = new CustomDialogForm();
            DialogResult dialogResult = customDialog.ShowDialog();
            
            MessageBox.Show(dialogResult.ToString() + " - Name: " + customDialog.YourName);
        }
    }
}