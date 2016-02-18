namespace DoubleBuffer
{
    partial class TestForm
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
            this.doubleBufferingCheckBox = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.animationCheckBox = new System.Windows.Forms.CheckBox();
            this.smoothingCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // doubleBufferingCheckBox
            // 
            this.doubleBufferingCheckBox.AutoSize = true;
            this.doubleBufferingCheckBox.Location = new System.Drawing.Point(12, 36);
            this.doubleBufferingCheckBox.Name = "doubleBufferingCheckBox";
            this.doubleBufferingCheckBox.Size = new System.Drawing.Size(107, 18);
            this.doubleBufferingCheckBox.TabIndex = 0;
            this.doubleBufferingCheckBox.Text = "Double buffering";
            this.doubleBufferingCheckBox.UseVisualStyleBackColor = true;
            this.doubleBufferingCheckBox.CheckedChanged += new System.EventHandler(this.doubleBufferingCheckBox_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // animationCheckBox
            // 
            this.animationCheckBox.AutoSize = true;
            this.animationCheckBox.Location = new System.Drawing.Point(12, 12);
            this.animationCheckBox.Name = "animationCheckBox";
            this.animationCheckBox.Size = new System.Drawing.Size(76, 18);
            this.animationCheckBox.TabIndex = 1;
            this.animationCheckBox.Text = "Animation";
            this.animationCheckBox.UseVisualStyleBackColor = true;
            this.animationCheckBox.CheckedChanged += new System.EventHandler(this.animationCheckBox_CheckedChanged);
            // 
            // smoothingCheckBox
            // 
            this.smoothingCheckBox.AutoSize = true;
            this.smoothingCheckBox.Location = new System.Drawing.Point(12, 60);
            this.smoothingCheckBox.Name = "smoothingCheckBox";
            this.smoothingCheckBox.Size = new System.Drawing.Size(77, 18);
            this.smoothingCheckBox.TabIndex = 0;
            this.smoothingCheckBox.Text = "Smoothing";
            this.smoothingCheckBox.UseVisualStyleBackColor = true;
            this.smoothingCheckBox.CheckedChanged += new System.EventHandler(this.smoothingCheckBox_CheckedChanged);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 372);
            this.Controls.Add(this.smoothingCheckBox);
            this.Controls.Add(this.doubleBufferingCheckBox);
            this.Controls.Add(this.animationCheckBox);
            this.Name = "TestForm";
            this.Text = "Double Buffering Test Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox doubleBufferingCheckBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox animationCheckBox;
        private System.Windows.Forms.CheckBox smoothingCheckBox;
    }
}

