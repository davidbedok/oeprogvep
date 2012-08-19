using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MDIApplication
{
    public partial class MDIParentForm: Form
    {
        private const string newDocumentText = "Új dokumentum ";

        public MDIParentForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIChildForm MDIChild = new MDIChildForm();
            MDIChild.MdiParent = this;
            MDIChild.Text = newDocumentText + this.MdiChildren.Length.ToString();
            MDIChild.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            MDIChildForm MDIChild = new MDIChildForm();
            MDIChild.MdiParent = this;
            MDIChild.Editor.LoadFile(openFileDialog.FileName);
            MDIChild.FileName = openFileDialog.FileName;
            MDIChild.Show();
        }
    
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

    }
}