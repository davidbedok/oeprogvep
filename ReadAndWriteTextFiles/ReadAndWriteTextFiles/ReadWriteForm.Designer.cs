namespace ReadAndWriteTextFiles
{
    partial class ReadWriteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.bOpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOpenFileName = new System.Windows.Forms.TextBox();
            this.customOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bParse = new System.Windows.Forms.Button();
            this.cbFireWater = new System.Windows.Forms.ComboBox();
            this.lbConsole = new System.Windows.Forms.ListBox();
            this.bSaveFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bSaveFile);
            this.groupBox1.Controls.Add(this.cbFireWater);
            this.groupBox1.Controls.Add(this.bParse);
            this.groupBox1.Controls.Add(this.rtbContent);
            this.groupBox1.Controls.Add(this.bOpenFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbOpenFileName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open (fruit.txt)";
            // 
            // rtbContent
            // 
            this.rtbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbContent.Location = new System.Drawing.Point(19, 48);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(437, 153);
            this.rtbContent.TabIndex = 3;
            this.rtbContent.Text = "";
            // 
            // bOpenFile
            // 
            this.bOpenFile.Location = new System.Drawing.Point(348, 19);
            this.bOpenFile.Name = "bOpenFile";
            this.bOpenFile.Size = new System.Drawing.Size(108, 23);
            this.bOpenFile.TabIndex = 2;
            this.bOpenFile.Text = "Open file";
            this.bOpenFile.UseVisualStyleBackColor = true;
            this.bOpenFile.Click += new System.EventHandler(this.bOpenFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filename:";
            // 
            // tbOpenFileName
            // 
            this.tbOpenFileName.Location = new System.Drawing.Point(74, 19);
            this.tbOpenFileName.Name = "tbOpenFileName";
            this.tbOpenFileName.ReadOnly = true;
            this.tbOpenFileName.Size = new System.Drawing.Size(268, 20);
            this.tbOpenFileName.TabIndex = 0;
            // 
            // customOpenFileDialog
            // 
            this.customOpenFileDialog.FileName = "openFileDialog1";
            // 
            // bParse
            // 
            this.bParse.Location = new System.Drawing.Point(176, 207);
            this.bParse.Name = "bParse";
            this.bParse.Size = new System.Drawing.Size(75, 23);
            this.bParse.TabIndex = 4;
            this.bParse.Text = "Parse";
            this.bParse.UseVisualStyleBackColor = true;
            this.bParse.Click += new System.EventHandler(this.bParse_Click);
            // 
            // cbFireWater
            // 
            this.cbFireWater.FormattingEnabled = true;
            this.cbFireWater.Location = new System.Drawing.Point(257, 209);
            this.cbFireWater.Name = "cbFireWater";
            this.cbFireWater.Size = new System.Drawing.Size(199, 21);
            this.cbFireWater.TabIndex = 5;
            // 
            // lbConsole
            // 
            this.lbConsole.FormattingEnabled = true;
            this.lbConsole.Location = new System.Drawing.Point(12, 262);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.Size = new System.Drawing.Size(474, 95);
            this.lbConsole.TabIndex = 1;
            // 
            // bSaveFile
            // 
            this.bSaveFile.Location = new System.Drawing.Point(19, 207);
            this.bSaveFile.Name = "bSaveFile";
            this.bSaveFile.Size = new System.Drawing.Size(75, 23);
            this.bSaveFile.TabIndex = 6;
            this.bSaveFile.Text = "Save file";
            this.bSaveFile.UseVisualStyleBackColor = true;
            this.bSaveFile.Click += new System.EventHandler(this.bSaveFile_Click);
            // 
            // ReadWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 366);
            this.Controls.Add(this.lbConsole);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReadWriteForm";
            this.Text = "Read and Write text files";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button bOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOpenFileName;
        private System.Windows.Forms.OpenFileDialog customOpenFileDialog;
        private System.Windows.Forms.ComboBox cbFireWater;
        private System.Windows.Forms.Button bParse;
        private System.Windows.Forms.ListBox lbConsole;
        private System.Windows.Forms.Button bSaveFile;
    }
}

