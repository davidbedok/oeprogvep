namespace Event
{
    partial class EventForm
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
            this.bCreate = new System.Windows.Forms.Button();
            this.tbMINVALUE = new System.Windows.Forms.TextBox();
            this.tbMAXVALUE = new System.Windows.Forms.TextBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPercent = new System.Windows.Forms.TextBox();
            this.bStep = new System.Windows.Forms.Button();
            this.tbStep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(12, 12);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(168, 23);
            this.bCreate.TabIndex = 0;
            this.bCreate.Text = "Start";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            this.bCreate.Click += new System.EventHandler(bCreate_Click4343);
            // 
            // tbMINVALUE
            // 
            this.tbMINVALUE.Location = new System.Drawing.Point(80, 51);
            this.tbMINVALUE.Name = "tbMINVALUE";
            this.tbMINVALUE.Size = new System.Drawing.Size(100, 20);
            this.tbMINVALUE.TabIndex = 1;
            this.tbMINVALUE.Text = "10";
            // 
            // tbMAXVALUE
            // 
            this.tbMAXVALUE.Location = new System.Drawing.Point(80, 77);
            this.tbMAXVALUE.Name = "tbMAXVALUE";
            this.tbMAXVALUE.Size = new System.Drawing.Size(100, 20);
            this.tbMAXVALUE.TabIndex = 2;
            this.tbMAXVALUE.Text = "100";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(80, 103);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(100, 20);
            this.tbValue.TabIndex = 3;
            this.tbValue.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MINVALUE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "MAXVALUE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "percent";
            // 
            // tbPercent
            // 
            this.tbPercent.Location = new System.Drawing.Point(80, 129);
            this.tbPercent.Name = "tbPercent";
            this.tbPercent.Size = new System.Drawing.Size(100, 20);
            this.tbPercent.TabIndex = 8;
            this.tbPercent.Text = "0";
            // 
            // bStep
            // 
            this.bStep.Enabled = false;
            this.bStep.Location = new System.Drawing.Point(15, 162);
            this.bStep.Name = "bStep";
            this.bStep.Size = new System.Drawing.Size(59, 23);
            this.bStep.TabIndex = 9;
            this.bStep.Text = "Step";
            this.bStep.UseVisualStyleBackColor = true;
            this.bStep.Click += new System.EventHandler(this.bStep_Click);
            // 
            // tbStep
            // 
            this.tbStep.Location = new System.Drawing.Point(80, 165);
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(100, 20);
            this.tbStep.TabIndex = 10;
            this.tbStep.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 206);
            this.Controls.Add(this.tbStep);
            this.Controls.Add(this.bStep);
            this.Controls.Add(this.tbPercent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.tbMAXVALUE);
            this.Controls.Add(this.tbMINVALUE);
            this.Controls.Add(this.bCreate);
            this.Name = "Form1";
            this.Text = "Event, Delegate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void bCreate_Click4343(object sender, System.EventArgs e)
        {
            // fergr
        }

        #endregion

        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.TextBox tbMINVALUE;
        private System.Windows.Forms.TextBox tbMAXVALUE;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPercent;
        private System.Windows.Forms.Button bStep;
        private System.Windows.Forms.TextBox tbStep;
    }
}

