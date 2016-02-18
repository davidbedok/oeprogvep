namespace OOPEvent
{
    partial class FormOOPEvent
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
            this.bSet = new System.Windows.Forms.Button();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // bSet
            // 
            this.bSet.Location = new System.Drawing.Point(93, 12);
            this.bSet.Name = "bSet";
            this.bSet.Size = new System.Drawing.Size(75, 23);
            this.bSet.TabIndex = 0;
            this.bSet.Text = "set";
            this.bSet.UseVisualStyleBackColor = true;
            this.bSet.Click += new System.EventHandler(this.bSet_Click);
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(12, 12);
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(75, 20);
            this.nudValue.TabIndex = 1;
            this.nudValue.Value = new decimal(new int[] {
            42,
            0,
            0,
            0});
            // 
            // FormOOPEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.bSet);
            this.Name = "FormOOPEvent";
            this.Text = "OOPEventForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSet;
        private System.Windows.Forms.NumericUpDown nudValue;
    }
}

