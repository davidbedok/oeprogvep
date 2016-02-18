namespace DrawCircle
{
    partial class CircleForm
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.bSimple = new System.Windows.Forms.Button();
            this.bMath = new System.Windows.Forms.Button();
            this.bExpert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.canvas);
            this.groupBox1.Location = new System.Drawing.Point(19, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture";
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(6, 19);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(600, 200);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // bSimple
            // 
            this.bSimple.Location = new System.Drawing.Point(19, 13);
            this.bSimple.Name = "bSimple";
            this.bSimple.Size = new System.Drawing.Size(200, 23);
            this.bSimple.TabIndex = 1;
            this.bSimple.Text = "Simple";
            this.bSimple.UseVisualStyleBackColor = true;
            this.bSimple.Click += new System.EventHandler(this.bSimple_Click);
            // 
            // bMath
            // 
            this.bMath.Location = new System.Drawing.Point(222, 12);
            this.bMath.Name = "bMath";
            this.bMath.Size = new System.Drawing.Size(200, 23);
            this.bMath.TabIndex = 2;
            this.bMath.Text = "Math";
            this.bMath.UseVisualStyleBackColor = true;
            this.bMath.Click += new System.EventHandler(this.bMath_Click);
            // 
            // bExpert
            // 
            this.bExpert.Location = new System.Drawing.Point(428, 12);
            this.bExpert.Name = "bExpert";
            this.bExpert.Size = new System.Drawing.Size(200, 23);
            this.bExpert.TabIndex = 3;
            this.bExpert.Text = "Expert";
            this.bExpert.UseVisualStyleBackColor = true;
            this.bExpert.Click += new System.EventHandler(this.bExpert_Click);
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 278);
            this.Controls.Add(this.bExpert);
            this.Controls.Add(this.bMath);
            this.Controls.Add(this.bSimple);
            this.Controls.Add(this.groupBox1);
            this.Name = "CircleForm";
            this.Text = "Draw circles";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button bSimple;
        private System.Windows.Forms.Button bMath;
        private System.Windows.Forms.Button bExpert;
    }
}

