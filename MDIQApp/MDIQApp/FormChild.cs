using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MDIQApp
{
    public partial class FormChild : Form
    {
        private const string DocumentModifiedIndicator = " *";

        private string fileName = string.Empty;

        public RichTextBox Editor
        {
            get { return richTextBox1; }
        }
        
        public string FileName
        {
            get { return fileName; }
            set
            {
                fileName = value;
                Text = value;
            }
        }

        public FormChild()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (CloseDocument())
            {
                Close();
            }
        }

        private void FormChild_FormClosing(object sender, FormClosingEventArgs e)
        {            
            if (!CloseDocument())
            {
                e.Cancel = true;
            }
        }

        private bool CloseDocument()
        {
            if (Editor.Modified)
                switch (MessageBox.Show("Kívánja menteni az utolsó módosításokat?", "Kérdés", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Cancel:
                        return false;
                    case DialogResult.No:
                        return true;
                    case DialogResult.Yes:
                        Save();
                        return true;
                    default:
                        return true;
                }
            else
                return true;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Editor.SelectionLength > 0)
                Editor.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Editor.SelectionLength > 0)
                Editor.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Editor.CanPaste(DataFormats.GetFormat(DataFormats.Rtf)) ||
                Editor.CanPaste(DataFormats.GetFormat(DataFormats.Text)) ||
                Editor.CanPaste(DataFormats.GetFormat(DataFormats.UnicodeText)))
                Editor.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Editor.SelectionLength > 0)
            {
                Editor.Text = Editor.Text.Substring(0, Editor.SelectionStart) + Editor.Text.Substring(Editor.SelectionStart + Editor.SelectionLength);
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Editor.CanUndo)
            {
                Editor.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Editor.CanRedo)
            {
                Editor.Redo();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Editor.Modified = true;
            if (Text.LastIndexOf(DocumentModifiedIndicator) != Text.Length - DocumentModifiedIndicator.Length)
            {
                Text += DocumentModifiedIndicator;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (FileName == string.Empty)
            {                
                SaveAs();
            } 
            else if (Editor.Modified)
            {
                Editor.SaveFile(FileName, RichTextBoxStreamType.RichText);
                Editor.Modified = false;
                if (Text.IndexOf(DocumentModifiedIndicator) != -1)
                {
                    Text = Text.Substring(0, Text.Length - DocumentModifiedIndicator.Length);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs(); 
        }

        private void SaveAs()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = saveFileDialog1.FileName;
                if (FileName != String.Empty)
                    Save();
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

    }
}