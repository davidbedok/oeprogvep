namespace CSLogoApplication
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbForward = new System.Windows.Forms.TextBox();
            this.tbBack = new System.Windows.Forms.TextBox();
            this.bForward = new System.Windows.Forms.Button();
            this.pColor = new System.Windows.Forms.Panel();
            this.bRight = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.bLeft = new System.Windows.Forms.Button();
            this.cbVisible = new System.Windows.Forms.CheckBox();
            this.tbLeft = new System.Windows.Forms.TextBox();
            this.tbRight = new System.Windows.Forms.TextBox();
            this.cbDraw = new System.Windows.Forms.CheckBox();
            this.pbCanvasDemo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDemoAngle = new System.Windows.Forms.TextBox();
            this.bDemoInit = new System.Windows.Forms.Button();
            this.tbDemoY = new System.Windows.Forms.TextBox();
            this.tbDemoX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.nudPenWidth = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvasDemo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPenWidth)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbForward, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbBack, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bForward, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bRight, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bBack, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bLeft, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbVisible, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbLeft, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbRight, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbDraw, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(279, 188);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // tbForward
            // 
            this.tbForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbForward.Location = new System.Drawing.Point(3, 5);
            this.tbForward.Name = "tbForward";
            this.tbForward.Size = new System.Drawing.Size(133, 20);
            this.tbForward.TabIndex = 23;
            this.tbForward.Text = "10";
            // 
            // tbBack
            // 
            this.tbBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBack.Location = new System.Drawing.Point(3, 35);
            this.tbBack.Name = "tbBack";
            this.tbBack.Size = new System.Drawing.Size(133, 20);
            this.tbBack.TabIndex = 25;
            this.tbBack.Text = "10";
            // 
            // bForward
            // 
            this.bForward.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bForward.Location = new System.Drawing.Point(142, 3);
            this.bForward.Name = "bForward";
            this.bForward.Size = new System.Drawing.Size(134, 23);
            this.bForward.TabIndex = 24;
            this.bForward.Text = "Forward";
            this.bForward.UseVisualStyleBackColor = true;
            this.bForward.Click += new System.EventHandler(this.bForward_Click);
            // 
            // pColor
            // 
            this.pColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pColor.BackColor = System.Drawing.Color.Green;
            this.pColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColor.Location = new System.Drawing.Point(3, 3);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(20, 18);
            this.pColor.TabIndex = 34;
            this.pColor.Click += new System.EventHandler(this.pColor_Click);
            // 
            // bRight
            // 
            this.bRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bRight.Location = new System.Drawing.Point(142, 93);
            this.bRight.Name = "bRight";
            this.bRight.Size = new System.Drawing.Size(134, 23);
            this.bRight.TabIndex = 30;
            this.bRight.Text = "Right";
            this.bRight.UseVisualStyleBackColor = true;
            this.bRight.Click += new System.EventHandler(this.bRight_Click);
            // 
            // bBack
            // 
            this.bBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bBack.Location = new System.Drawing.Point(142, 33);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(134, 23);
            this.bBack.TabIndex = 26;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bLeft
            // 
            this.bLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bLeft.Location = new System.Drawing.Point(142, 63);
            this.bLeft.Name = "bLeft";
            this.bLeft.Size = new System.Drawing.Size(134, 23);
            this.bLeft.TabIndex = 29;
            this.bLeft.Text = "Left";
            this.bLeft.UseVisualStyleBackColor = true;
            this.bLeft.Click += new System.EventHandler(this.bLeft_Click);
            // 
            // cbVisible
            // 
            this.cbVisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVisible.AutoSize = true;
            this.cbVisible.Checked = true;
            this.cbVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVisible.Location = new System.Drawing.Point(3, 160);
            this.cbVisible.Name = "cbVisible";
            this.cbVisible.Size = new System.Drawing.Size(133, 17);
            this.cbVisible.TabIndex = 0;
            this.cbVisible.Text = "Visible";
            this.cbVisible.UseVisualStyleBackColor = true;
            this.cbVisible.CheckedChanged += new System.EventHandler(this.cbVisible_CheckedChanged);
            // 
            // tbLeft
            // 
            this.tbLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLeft.Location = new System.Drawing.Point(3, 65);
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.Size = new System.Drawing.Size(133, 20);
            this.tbLeft.TabIndex = 27;
            this.tbLeft.Text = "30";
            // 
            // tbRight
            // 
            this.tbRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRight.Location = new System.Drawing.Point(3, 95);
            this.tbRight.Name = "tbRight";
            this.tbRight.Size = new System.Drawing.Size(133, 20);
            this.tbRight.TabIndex = 28;
            this.tbRight.Text = "30";
            // 
            // cbDraw
            // 
            this.cbDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDraw.AutoSize = true;
            this.cbDraw.Checked = true;
            this.cbDraw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDraw.Location = new System.Drawing.Point(3, 126);
            this.cbDraw.Name = "cbDraw";
            this.cbDraw.Size = new System.Drawing.Size(133, 17);
            this.cbDraw.TabIndex = 31;
            this.cbDraw.Text = "Draw";
            this.cbDraw.UseVisualStyleBackColor = true;
            this.cbDraw.CheckedChanged += new System.EventHandler(this.cbDraw_CheckedChanged);
            // 
            // pbCanvasDemo
            // 
            this.pbCanvasDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCanvasDemo.Location = new System.Drawing.Point(3, 203);
            this.pbCanvasDemo.Name = "pbCanvasDemo";
            this.pbCanvasDemo.Size = new System.Drawing.Size(571, 325);
            this.pbCanvasDemo.TabIndex = 22;
            this.pbCanvasDemo.TabStop = false;
            this.pbCanvasDemo.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvasDemo_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDemoAngle);
            this.groupBox1.Controls.Add(this.bDemoInit);
            this.groupBox1.Controls.Add(this.tbDemoY);
            this.groupBox1.Controls.Add(this.tbDemoX);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(288, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 188);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turtle";
            // 
            // tbDemoAngle
            // 
            this.tbDemoAngle.Enabled = false;
            this.tbDemoAngle.Location = new System.Drawing.Point(61, 99);
            this.tbDemoAngle.Name = "tbDemoAngle";
            this.tbDemoAngle.Size = new System.Drawing.Size(133, 20);
            this.tbDemoAngle.TabIndex = 6;
            // 
            // bDemoInit
            // 
            this.bDemoInit.Location = new System.Drawing.Point(12, 132);
            this.bDemoInit.Name = "bDemoInit";
            this.bDemoInit.Size = new System.Drawing.Size(108, 23);
            this.bDemoInit.TabIndex = 32;
            this.bDemoInit.Text = "Init";
            this.bDemoInit.UseVisualStyleBackColor = true;
            this.bDemoInit.Click += new System.EventHandler(this.bDemoInit_Click);
            // 
            // tbDemoY
            // 
            this.tbDemoY.Enabled = false;
            this.tbDemoY.Location = new System.Drawing.Point(61, 74);
            this.tbDemoY.Name = "tbDemoY";
            this.tbDemoY.Size = new System.Drawing.Size(133, 20);
            this.tbDemoY.TabIndex = 5;
            // 
            // tbDemoX
            // 
            this.tbDemoX.Enabled = false;
            this.tbDemoX.Location = new System.Drawing.Point(61, 51);
            this.tbDemoX.Name = "tbDemoX";
            this.tbDemoX.Size = new System.Drawing.Size(133, 20);
            this.tbDemoX.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Angle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "X";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pbCanvasDemo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(577, 531);
            this.tableLayoutPanel2.TabIndex = 38;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(571, 194);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // nudPenWidth
            // 
            this.nudPenWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPenWidth.Location = new System.Drawing.Point(29, 3);
            this.nudPenWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPenWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPenWidth.Name = "nudPenWidth";
            this.nudPenWidth.Size = new System.Drawing.Size(102, 20);
            this.nudPenWidth.TabIndex = 35;
            this.nudPenWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPenWidth.ValueChanged += new System.EventHandler(this.nudPenWidth_ValueChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.Controls.Add(this.pColor, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.nudPenWidth, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(142, 123);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(134, 24);
            this.tableLayoutPanel4.TabIndex = 36;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 531);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Resize += new System.EventHandler(this.TestForm_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvasDemo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPenWidth)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvasDemo;
        private System.Windows.Forms.TextBox tbForward;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.Button bForward;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDemoAngle;
        private System.Windows.Forms.TextBox tbDemoY;
        private System.Windows.Forms.TextBox tbDemoX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbVisible;
        private System.Windows.Forms.TextBox tbBack;
        private System.Windows.Forms.Button bDemoInit;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.CheckBox cbDraw;
        private System.Windows.Forms.TextBox tbLeft;
        private System.Windows.Forms.Button bRight;
        private System.Windows.Forms.TextBox tbRight;
        private System.Windows.Forms.Button bLeft;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.NumericUpDown nudPenWidth;
    }
}