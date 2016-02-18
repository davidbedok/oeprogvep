namespace Bloxorz
{
    partial class BloxorzForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbTerrain = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbLevels = new System.Windows.Forms.ListBox();
            this.lbErrors = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTerrain)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pbTerrain, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 337);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pbTerrain
            // 
            this.pbTerrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTerrain.Location = new System.Drawing.Point(203, 3);
            this.pbTerrain.Name = "pbTerrain";
            this.pbTerrain.Size = new System.Drawing.Size(555, 331);
            this.pbTerrain.TabIndex = 1;
            this.pbTerrain.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbLevels, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbErrors, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 331);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lbLevels
            // 
            this.lbLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLevels.FormattingEnabled = true;
            this.lbLevels.Location = new System.Drawing.Point(3, 3);
            this.lbLevels.Name = "lbLevels";
            this.lbLevels.Size = new System.Drawing.Size(188, 159);
            this.lbLevels.TabIndex = 1;
            this.lbLevels.SelectedIndexChanged += new System.EventHandler(this.lbLevels_SelectedIndexChanged);
            // 
            // lbErrors
            // 
            this.lbErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbErrors.FormattingEnabled = true;
            this.lbErrors.HorizontalScrollbar = true;
            this.lbErrors.Location = new System.Drawing.Point(3, 168);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(188, 160);
            this.lbErrors.TabIndex = 2;
            // 
            // BloxorzForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 337);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BloxorzForm";
            this.Text = ":: Bloxorz ::";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTerrain)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbTerrain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox lbLevels;
        private System.Windows.Forms.ListBox lbErrors;
    }
}

