namespace Sorts
{
    partial class SortForm
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
            this.nArraySize = new System.Windows.Forms.NumericUpDown();
            this.lKivalasztasosCsere = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bCreate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lBuborekosCsere = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUp = new System.Windows.Forms.RadioButton();
            this.rbDown = new System.Windows.Forms.RadioButton();
            this.lbOriginal = new System.Windows.Forms.ListBox();
            this.lbBubbles = new System.Windows.Forms.ListBox();
            this.lbExcretory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nArraySize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nArraySize
            // 
            this.nArraySize.Location = new System.Drawing.Point(84, 12);
            this.nArraySize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nArraySize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nArraySize.Name = "nArraySize";
            this.nArraySize.Size = new System.Drawing.Size(78, 20);
            this.nArraySize.TabIndex = 0;
            this.nArraySize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lKivalasztasosCsere
            // 
            this.lKivalasztasosCsere.AutoSize = true;
            this.lKivalasztasosCsere.Location = new System.Drawing.Point(135, 80);
            this.lKivalasztasosCsere.Name = "lKivalasztasosCsere";
            this.lKivalasztasosCsere.Size = new System.Drawing.Size(13, 13);
            this.lKivalasztasosCsere.TabIndex = 1;
            this.lKivalasztasosCsere.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(125, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Swap number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bubble";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(236, 9);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(67, 23);
            this.bCreate.TabIndex = 4;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Excretory";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lBuborekosCsere
            // 
            this.lBuborekosCsere.AutoSize = true;
            this.lBuborekosCsere.Location = new System.Drawing.Point(135, 56);
            this.lBuborekosCsere.Name = "lBuborekosCsere";
            this.lBuborekosCsere.Size = new System.Drawing.Size(13, 13);
            this.lBuborekosCsere.TabIndex = 6;
            this.lBuborekosCsere.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Array size:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDown);
            this.groupBox1.Controls.Add(this.rbUp);
            this.groupBox1.Location = new System.Drawing.Point(236, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(71, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // rbUp
            // 
            this.rbUp.AutoSize = true;
            this.rbUp.Checked = true;
            this.rbUp.Location = new System.Drawing.Point(14, 19);
            this.rbUp.Name = "rbUp";
            this.rbUp.Size = new System.Drawing.Size(39, 17);
            this.rbUp.TabIndex = 0;
            this.rbUp.TabStop = true;
            this.rbUp.Text = "Up";
            this.rbUp.UseVisualStyleBackColor = true;
            this.rbUp.CheckedChanged += new System.EventHandler(this.rbUp_CheckedChanged);
            // 
            // rbDown
            // 
            this.rbDown.AutoSize = true;
            this.rbDown.Location = new System.Drawing.Point(14, 37);
            this.rbDown.Name = "rbDown";
            this.rbDown.Size = new System.Drawing.Size(53, 17);
            this.rbDown.TabIndex = 1;
            this.rbDown.Text = "Down";
            this.rbDown.UseVisualStyleBackColor = true;
            this.rbDown.CheckedChanged += new System.EventHandler(this.rbDown_CheckedChanged);
            // 
            // lbOriginal
            // 
            this.lbOriginal.FormattingEnabled = true;
            this.lbOriginal.Location = new System.Drawing.Point(15, 121);
            this.lbOriginal.Name = "lbOriginal";
            this.lbOriginal.Size = new System.Drawing.Size(94, 147);
            this.lbOriginal.TabIndex = 9;
            // 
            // lbBubbles
            // 
            this.lbBubbles.FormattingEnabled = true;
            this.lbBubbles.Location = new System.Drawing.Point(114, 121);
            this.lbBubbles.Name = "lbBubbles";
            this.lbBubbles.Size = new System.Drawing.Size(94, 147);
            this.lbBubbles.TabIndex = 10;
            // 
            // lbExcretory
            // 
            this.lbExcretory.FormattingEnabled = true;
            this.lbExcretory.Location = new System.Drawing.Point(212, 121);
            this.lbExcretory.Name = "lbExcretory";
            this.lbExcretory.Size = new System.Drawing.Size(94, 147);
            this.lbExcretory.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Original Array";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "BubbleSort Array";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ExcretorySort Array";
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 290);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbExcretory);
            this.Controls.Add(this.lbBubbles);
            this.Controls.Add(this.lbOriginal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lBuborekosCsere);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lKivalasztasosCsere);
            this.Controls.Add(this.nArraySize);
            this.Name = "SortForm";
            this.Text = "Sort Form";
            ((System.ComponentModel.ISupportInitialize)(this.nArraySize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nArraySize;
        private System.Windows.Forms.Label lKivalasztasosCsere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lBuborekosCsere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDown;
        private System.Windows.Forms.RadioButton rbUp;
        private System.Windows.Forms.ListBox lbOriginal;
        private System.Windows.Forms.ListBox lbBubbles;
        private System.Windows.Forms.ListBox lbExcretory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

