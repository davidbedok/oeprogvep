namespace GraphicsExample
{
    partial class MainForm
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
            this.gestureControl = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize) (this.gestureControl)).BeginInit();
            this.SuspendLayout();
            // 
            // gestureControl
            // 
            this.gestureControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gestureControl.Location = new System.Drawing.Point(241, 13);
            this.gestureControl.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gestureControl.Name = "gestureControl";
            this.gestureControl.Size = new System.Drawing.Size(50, 22);
            this.gestureControl.TabIndex = 0;
            this.gestureControl.ValueChanged += new System.EventHandler(this.gestureControl_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 602);
            this.Controls.Add(this.gestureControl);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Fej";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize) (this.gestureControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown gestureControl;
    }
}

