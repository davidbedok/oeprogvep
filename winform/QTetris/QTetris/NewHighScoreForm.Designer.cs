namespace QTetris
{
    partial class NewHighScoreForm
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
            this.bOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lStartLevel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bOK
            // 
            this.bOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOK.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bOK.Location = new System.Drawing.Point(265, 58);
            this.bOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(88, 23);
            this.bOK.TabIndex = 0;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player name:";
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(102, 19);
            this.tbPlayerName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(251, 21);
            this.tbPlayerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start level:";
            // 
            // lStartLevel
            // 
            this.lStartLevel.AutoSize = true;
            this.lStartLevel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lStartLevel.Location = new System.Drawing.Point(99, 63);
            this.lStartLevel.Name = "lStartLevel";
            this.lStartLevel.Size = new System.Drawing.Size(22, 13);
            this.lStartLevel.TabIndex = 4;
            this.lStartLevel.Text = "L1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Points:";
            // 
            // lPoints
            // 
            this.lPoints.AutoSize = true;
            this.lPoints.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPoints.Location = new System.Drawing.Point(203, 63);
            this.lPoints.Name = "lPoints";
            this.lPoints.Size = new System.Drawing.Size(15, 13);
            this.lPoints.TabIndex = 6;
            this.lPoints.Text = "0";
            // 
            // NewHighScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 93);
            this.Controls.Add(this.lPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lStartLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bOK);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NewHighScoreForm";
            this.Text = "Add your name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lStartLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lPoints;
    }
}