using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MDIQApp
{
    public partial class FormMDIContainer : Form
    {
        public FormMDIContainer()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild MDIchild = new FormChild();
            MDIchild.MdiParent = this;
            MDIchild.Text = "Form - " + this.MdiChildren.Length.ToString();
            MDIchild.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FormChild MDIchild = new FormChild();
            MDIchild.MdiParent = this;
            string extension = System.IO.Path.GetExtension(openFileDialog1.FileName);
            RichTextBoxStreamType rtbst = RichTextBoxStreamType.PlainText;
            switch (extension)
            {
                case ".txt": 
                    rtbst = RichTextBoxStreamType.PlainText;
                    break;
                case ".rtf":
                    rtbst = RichTextBoxStreamType.RichText;
                    break;
            }
            MDIchild.Editor.LoadFile(openFileDialog1.FileName, rtbst);
            MDIchild.Text = openFileDialog1.FileName;
            MDIchild.Editor.Modified = false;
            MDIchild.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void horizontalTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);            
        }

        private void verticalTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical); 
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

    }
}