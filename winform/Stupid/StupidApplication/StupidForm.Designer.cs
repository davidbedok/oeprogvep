namespace WindowsApplication1
{
    partial class StupidForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bYES = new System.Windows.Forms.Button();
            this.bNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you Stupid?";
            // 
            // bYES
            // 
            this.bYES.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bYES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bYES.Location = new System.Drawing.Point(79, 55);
            this.bYES.Name = "bYES";
            this.bYES.Size = new System.Drawing.Size(75, 23);
            this.bYES.TabIndex = 1;
            this.bYES.TabStop = false;
            this.bYES.Text = "YES";
            this.bYES.UseVisualStyleBackColor = true;
            this.bYES.Validated += new System.EventHandler(this.bYES_Validated);
            this.bYES.Click += new System.EventHandler(this.bYES_Click);
            // 
            // bNO
            // 
            this.bNO.Location = new System.Drawing.Point(160, 55);
            this.bNO.Name = "bNO";
            this.bNO.Size = new System.Drawing.Size(75, 23);
            this.bNO.TabIndex = 2;
            this.bNO.TabStop = false;
            this.bNO.Text = "NO";
            this.bNO.UseVisualStyleBackColor = true;
            this.bNO.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bNO_MouseMove);
            this.bNO.Click += new System.EventHandler(this.bNO_Click);
            // 
            // StupidForm
            // 
            this.AcceptButton = this.bYES;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bYES;
            this.ClientSize = new System.Drawing.Size(318, 90);
            this.ControlBox = false;
            this.Controls.Add(this.bNO);
            this.Controls.Add(this.bYES);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StupidForm";
            this.Opacity = 0.7;
            this.ShowInTaskbar = false;
            this.Text = "Stupid";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bYES;
        private System.Windows.Forms.Button bNO;
    }
}

