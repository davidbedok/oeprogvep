namespace TimerApp
{
    partial class BallTimerForm
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
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.BStart = new System.Windows.Forms.Button();
            this.timerBall = new System.Windows.Forms.Timer(this.components);
            this.bStop = new System.Windows.Forms.Button();
            this.bMultiStart = new System.Windows.Forms.Button();
            this.bMultiStop = new System.Windows.Forms.Button();
            this.timerBalls = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCanvas.Location = new System.Drawing.Point(3, 3);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(592, 281);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            // 
            // BStart
            // 
            this.BStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BStart.Location = new System.Drawing.Point(3, 3);
            this.BStart.Name = "BStart";
            this.BStart.Size = new System.Drawing.Size(290, 26);
            this.BStart.TabIndex = 1;
            this.BStart.Text = "Start";
            this.BStart.UseVisualStyleBackColor = true;
            this.BStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // timerBall
            // 
            this.timerBall.Interval = 50;
            this.timerBall.Tick += new System.EventHandler(this.timerBall_Tick);
            // 
            // bStop
            // 
            this.bStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bStop.Location = new System.Drawing.Point(299, 3);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(290, 26);
            this.bStop.TabIndex = 2;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bMultiStart
            // 
            this.bMultiStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bMultiStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMultiStart.Location = new System.Drawing.Point(3, 35);
            this.bMultiStart.Name = "bMultiStart";
            this.bMultiStart.Size = new System.Drawing.Size(290, 26);
            this.bMultiStart.TabIndex = 3;
            this.bMultiStart.Text = "Multi Start";
            this.bMultiStart.UseVisualStyleBackColor = true;
            this.bMultiStart.Click += new System.EventHandler(this.bMultiStart_Click);
            // 
            // bMultiStop
            // 
            this.bMultiStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bMultiStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMultiStop.Location = new System.Drawing.Point(299, 35);
            this.bMultiStop.Name = "bMultiStop";
            this.bMultiStop.Size = new System.Drawing.Size(290, 26);
            this.bMultiStop.TabIndex = 4;
            this.bMultiStop.Text = "Multi Stop";
            this.bMultiStop.UseVisualStyleBackColor = true;
            this.bMultiStop.Click += new System.EventHandler(this.bMultiStop_Click);
            // 
            // timerBalls
            // 
            this.timerBalls.Tick += new System.EventHandler(this.timerBalls_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbCanvas, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 357);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BStart, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bMultiStop, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.bStop, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bMultiStart, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 290);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(592, 64);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BallTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 357);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "BallTimerForm";
            this.Text = "Ball Timer";
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Button BStart;
        private System.Windows.Forms.Timer timerBall;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bMultiStart;
        private System.Windows.Forms.Button bMultiStop;
        private System.Windows.Forms.Timer timerBalls;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

