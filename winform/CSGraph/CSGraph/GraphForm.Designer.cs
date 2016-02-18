namespace CSGraph
{
    partial class GraphForm
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
            this.bClear = new System.Windows.Forms.Button();
            this.bDraw = new System.Windows.Forms.Button();
            this.bOpen = new System.Windows.Forms.Button();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bAddEdge = new System.Windows.Forms.Button();
            this.cbEdges = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPointB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPointA = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bClear);
            this.groupBox1.Controls.Add(this.bDraw);
            this.groupBox1.Controls.Add(this.bOpen);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation";
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(134, 74);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(97, 23);
            this.bClear.TabIndex = 3;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bDraw
            // 
            this.bDraw.Location = new System.Drawing.Point(6, 74);
            this.bDraw.Name = "bDraw";
            this.bDraw.Size = new System.Drawing.Size(97, 23);
            this.bDraw.TabIndex = 2;
            this.bDraw.Text = "Draw";
            this.bDraw.UseVisualStyleBackColor = true;
            this.bDraw.Click += new System.EventHandler(this.bDraw_Click);
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(6, 19);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(225, 23);
            this.bOpen.TabIndex = 0;
            this.bOpen.Text = "Open";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // pbCanvas
            // 
            this.pbCanvas.Location = new System.Drawing.Point(12, 125);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(562, 289);
            this.pbCanvas.TabIndex = 1;
            this.pbCanvas.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bAddEdge);
            this.groupBox2.Controls.Add(this.cbEdges);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbPointB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbPointA);
            this.groupBox2.Location = new System.Drawing.Point(255, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // bAddEdge
            // 
            this.bAddEdge.Location = new System.Drawing.Point(230, 32);
            this.bAddEdge.Name = "bAddEdge";
            this.bAddEdge.Size = new System.Drawing.Size(83, 23);
            this.bAddEdge.TabIndex = 6;
            this.bAddEdge.Text = "Add Edge";
            this.bAddEdge.UseVisualStyleBackColor = true;
            this.bAddEdge.Click += new System.EventHandler(this.bAddEdge_Click);
            // 
            // cbEdges
            // 
            this.cbEdges.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEdges.FormattingEnabled = true;
            this.cbEdges.Location = new System.Drawing.Point(72, 73);
            this.cbEdges.Name = "cbEdges";
            this.cbEdges.Size = new System.Drawing.Size(151, 21);
            this.cbEdges.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edges:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Point B:";
            // 
            // cbPointB
            // 
            this.cbPointB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPointB.FormattingEnabled = true;
            this.cbPointB.Location = new System.Drawing.Point(72, 46);
            this.cbPointB.Name = "cbPointB";
            this.cbPointB.Size = new System.Drawing.Size(151, 21);
            this.cbPointB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Point A:";
            // 
            // cbPointA
            // 
            this.cbPointA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPointA.FormattingEnabled = true;
            this.cbPointA.Location = new System.Drawing.Point(72, 19);
            this.cbPointA.Name = "cbPointA";
            this.cbPointA.Size = new System.Drawing.Size(152, 21);
            this.cbPointA.TabIndex = 0;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 428);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pbCanvas);
            this.Controls.Add(this.groupBox1);
            this.Name = "GraphForm";
            this.Text = "Graph Form";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPointB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPointA;
        private System.Windows.Forms.ComboBox cbEdges;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bDraw;
        private System.Windows.Forms.Button bAddEdge;
        private System.Windows.Forms.Button bClear;
    }
}

