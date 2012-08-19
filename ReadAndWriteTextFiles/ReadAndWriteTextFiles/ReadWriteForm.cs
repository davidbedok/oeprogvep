using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ReadAndWriteTextFiles
{
    public partial class ReadWriteForm : Form
    {
        public ReadWriteForm()
        {
            InitializeComponent();
            this.customOpenFileDialog.Filter = "Text files (*.txt)|*.txt";
        }

        private void bOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = this.customOpenFileDialog.ShowDialog();
            if (DialogResult.OK == dialogResult)
            {
                this.tbOpenFileName.Text = this.customOpenFileDialog.FileName;
                string fileContent = this.openFile(this.tbOpenFileName.Text);
                this.rtbContent.Text = fileContent;
                this.parse(fileContent);
            }
        }

        private string openFile(string fileName)
        {
            StreamReader reader = File.OpenText(fileName);
            StringBuilder content = new StringBuilder(100);
            string line = reader.ReadLine();
            while (line != null)
            {
                content.AppendLine(line);
                line = reader.ReadLine();
            }
            reader.Close();
            return content.ToString();
        }

        private List<FireWater> parseFile(string content)
        {
            List<FireWater> fireWaters = new List<FireWater>();
            using (StringReader reader = new StringReader(content))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    try
                    {
                        fireWaters.Add(FireWater.parse(line));
                    }
                    catch (BadFileFormatException e)
                    {
                        this.lbConsole.Items.Add(e.Message);
                    }
                }
            }
            return fireWaters;
        }

        private void bSaveFile_Click(object sender, EventArgs e)
        {
            if ( ( this.tbOpenFileName.Text != null ) && (!"".Equals(this.tbOpenFileName.Text) ) ) {
                this.saveFile(this.tbOpenFileName.Text, this.rtbContent.Text);
            }
        }

        private void saveFile(string fileName, string content)
        {
            StreamWriter writer = File.CreateText(fileName);
            using (StringReader reader = new StringReader(content))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line);
                }
            }
            writer.Close();
        }

        private void bParse_Click(object sender, EventArgs e)
        {
            this.parse(this.rtbContent.Text);
        }

        private void parse(string fileContent)
        {
            this.cbFireWater.Items.Clear();
            this.cbFireWater.Items.AddRange(this.parseFile(fileContent).ToArray());
            if (this.cbFireWater.Items.Count > 0)
            {
                this.cbFireWater.SelectedIndex = 0;
            }
        }

    }
}
