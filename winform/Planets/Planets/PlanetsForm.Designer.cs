namespace Planets
{
    partial class PlanetsForm
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
            this.components = new System.ComponentModel.Container();
            this.tlpOuter = new System.Windows.Forms.TableLayoutPanel();
            this.tlpInner = new System.Windows.Forms.TableLayoutPanel();
            this.output = new System.Windows.Forms.RichTextBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.bStart = new System.Windows.Forms.Button();
            this.planetTimer = new System.Windows.Forms.Timer(this.components);
            this.tlpOuter.SuspendLayout();
            this.tlpInner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpOuter
            // 
            this.tlpOuter.ColumnCount = 1;
            this.tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOuter.Controls.Add(this.tlpInner, 0, 1);
            this.tlpOuter.Controls.Add(this.bStart, 0, 0);
            this.tlpOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOuter.Location = new System.Drawing.Point(0, 0);
            this.tlpOuter.Name = "tlpOuter";
            this.tlpOuter.RowCount = 2;
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOuter.Size = new System.Drawing.Size(718, 354);
            this.tlpOuter.TabIndex = 0;
            // 
            // tlpInner
            // 
            this.tlpInner.ColumnCount = 2;
            this.tlpInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInner.Controls.Add(this.output, 0, 0);
            this.tlpInner.Controls.Add(this.image, 1, 0);
            this.tlpInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInner.Location = new System.Drawing.Point(3, 53);
            this.tlpInner.Name = "tlpInner";
            this.tlpInner.RowCount = 1;
            this.tlpInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInner.Size = new System.Drawing.Size(712, 298);
            this.tlpInner.TabIndex = 0;
            // 
            // output
            // 
            this.output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output.Location = new System.Drawing.Point(3, 3);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(194, 292);
            this.output.TabIndex = 0;
            this.output.Text = "";
            // 
            // image
            // 
            this.image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image.Location = new System.Drawing.Point(203, 3);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(506, 292);
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // bStart
            // 
            this.bStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bStart.Location = new System.Drawing.Point(3, 3);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(712, 44);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // planetTimer
            // 
            this.planetTimer.Interval = 10;
            this.planetTimer.Tick += new System.EventHandler(this.planetTimer_Tick);
            // 
            // PlanetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 354);
            this.Controls.Add(this.tlpOuter);
            this.Name = "PlanetsForm";
            this.Text = "SolarSystem";
            this.tlpOuter.ResumeLayout(false);
            this.tlpInner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpOuter;
        private System.Windows.Forms.TableLayoutPanel tlpInner;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Timer planetTimer;
    }
}

