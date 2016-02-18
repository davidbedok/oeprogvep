namespace Graphics1
{
    partial class GraphicsDemo
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
            this.bDraw = new System.Windows.Forms.Button();
            this.bPaint = new System.Windows.Forms.Button();
            this.bIndependent = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbLines = new System.Windows.Forms.PictureBox();
            this.bLine1 = new System.Windows.Forms.Button();
            this.bLine2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLines)).BeginInit();
            this.SuspendLayout();
            // 
            // bDraw
            // 
            this.bDraw.Location = new System.Drawing.Point(12, 12);
            this.bDraw.Name = "bDraw";
            this.bDraw.Size = new System.Drawing.Size(98, 94);
            this.bDraw.TabIndex = 0;
            this.bDraw.Text = "Draw";
            this.bDraw.UseVisualStyleBackColor = true;
            this.bDraw.Click += new System.EventHandler(this.bDraw_Click);
            // 
            // bPaint
            // 
            this.bPaint.Location = new System.Drawing.Point(116, 12);
            this.bPaint.Name = "bPaint";
            this.bPaint.Size = new System.Drawing.Size(89, 94);
            this.bPaint.TabIndex = 1;
            this.bPaint.Text = "Paint";
            this.bPaint.UseVisualStyleBackColor = true;
            this.bPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.bPaint_Paint);
            // 
            // bIndependent
            // 
            this.bIndependent.Location = new System.Drawing.Point(211, 12);
            this.bIndependent.Name = "bIndependent";
            this.bIndependent.Size = new System.Drawing.Size(106, 94);
            this.bIndependent.TabIndex = 2;
            this.bIndependent.Text = "Independent";
            this.bIndependent.UseVisualStyleBackColor = true;
            this.bIndependent.Click += new System.EventHandler(this.bIndependent_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 104);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pbLines
            // 
            this.pbLines.Location = new System.Drawing.Point(12, 222);
            this.pbLines.Name = "pbLines";
            this.pbLines.Size = new System.Drawing.Size(305, 104);
            this.pbLines.TabIndex = 4;
            this.pbLines.TabStop = false;
            this.pbLines.Paint += new System.Windows.Forms.PaintEventHandler(this.pbLines_Paint);
            // 
            // bLine1
            // 
            this.bLine1.Location = new System.Drawing.Point(12, 333);
            this.bLine1.Name = "bLine1";
            this.bLine1.Size = new System.Drawing.Size(75, 23);
            this.bLine1.TabIndex = 5;
            this.bLine1.Text = "Line1";
            this.bLine1.UseVisualStyleBackColor = true;
            this.bLine1.Click += new System.EventHandler(this.bLine1_Click);
            // 
            // bLine2
            // 
            this.bLine2.Location = new System.Drawing.Point(93, 332);
            this.bLine2.Name = "bLine2";
            this.bLine2.Size = new System.Drawing.Size(75, 23);
            this.bLine2.TabIndex = 6;
            this.bLine2.Text = "Line2";
            this.bLine2.UseVisualStyleBackColor = true;
            this.bLine2.Click += new System.EventHandler(this.bLine2_Click);
            // 
            // GraphicsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 364);
            this.Controls.Add(this.bLine2);
            this.Controls.Add(this.bLine1);
            this.Controls.Add(this.pbLines);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bIndependent);
            this.Controls.Add(this.bPaint);
            this.Controls.Add(this.bDraw);
            this.Name = "GraphicsDemo";
            this.Text = "Graphics demo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bDraw;
        private System.Windows.Forms.Button bPaint;
        private System.Windows.Forms.Button bIndependent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbLines;
        private System.Windows.Forms.Button bLine1;
        private System.Windows.Forms.Button bLine2;
    }
}

