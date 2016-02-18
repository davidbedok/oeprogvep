using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileInfo
{
    public partial class FileInfoForm : Form
    {
        public FileInfoForm()
        {
            InitializeComponent();
        }

        private void bSelectDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lbContent.Items.Clear();
                string selectedDirectory = folderBrowserDialog1.SelectedPath;
                tbPath.Text = selectedDirectory;
                string[] directories = Directory.GetDirectories(selectedDirectory);
                for (int i = 0; i < directories.Length; i++)
                {
                    directories[i] = directories[i].Replace(selectedDirectory,"");
                    lbContent.Items.Add(directories[i]);
                }
                string[] files = Directory.GetFiles(selectedDirectory);
                for (int i = 0; i < files.Length; i++)
                {
                    lbContent.Items.Add(Path.DirectorySeparatorChar + Path.GetFileName(files[i]));
                }
            }
        }

        private void lbContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string objectName = tbPath.Text + lbContent.SelectedItem.ToString();
            rtbDetails.Text = "Name: " + objectName.ToString() + "\n";
            DateTime iCreateDt = File.GetCreationTime(objectName);
            DateTime iAccessDt = File.GetLastAccessTime(objectName);
            DateTime iWriteDt = File.GetLastWriteTime(objectName);
            rtbDetails.Text += "Create date: "+iCreateDt.ToString()+"\n";
            rtbDetails.Text += "Last access date: " + iAccessDt.ToString() + "\n";
            rtbDetails.Text += "Last write date: " + iWriteDt.ToString() + "\n";
            rtbDetails.Text += "Access control: " + File.GetAccessControl(objectName).ToString() + "\n";
            rtbDetails.Text += "Attributes: " + File.GetAttributes(objectName).ToString() + "\n";
        }

    }
}


       