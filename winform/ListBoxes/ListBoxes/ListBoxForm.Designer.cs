namespace ListBoxes
{
    partial class ListBoxForm
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
            this.lbA = new System.Windows.Forms.ListBox();
            this.lbB = new System.Windows.Forms.ListBox();
            this.bMoveToB = new System.Windows.Forms.Button();
            this.bMoveToBB = new System.Windows.Forms.Button();
            this.bMoveToA = new System.Windows.Forms.Button();
            this.bMoveToAA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbPeople = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.FormattingEnabled = true;
            this.lbA.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.lbA.Location = new System.Drawing.Point(6, 45);
            this.lbA.Name = "lbA";
            this.lbA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbA.Size = new System.Drawing.Size(92, 108);
            this.lbA.TabIndex = 0;
            // 
            // lbB
            // 
            this.lbB.FormattingEnabled = true;
            this.lbB.Location = new System.Drawing.Point(160, 47);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(92, 108);
            this.lbB.TabIndex = 1;
            // 
            // bMoveToB
            // 
            this.bMoveToB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMoveToB.Location = new System.Drawing.Point(104, 45);
            this.bMoveToB.Name = "bMoveToB";
            this.bMoveToB.Size = new System.Drawing.Size(50, 23);
            this.bMoveToB.TabIndex = 2;
            this.bMoveToB.Text = ">";
            this.bMoveToB.UseVisualStyleBackColor = true;
            this.bMoveToB.Click += new System.EventHandler(this.bMoveToB_Click);
            // 
            // bMoveToBB
            // 
            this.bMoveToBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMoveToBB.Location = new System.Drawing.Point(104, 74);
            this.bMoveToBB.Name = "bMoveToBB";
            this.bMoveToBB.Size = new System.Drawing.Size(50, 23);
            this.bMoveToBB.TabIndex = 3;
            this.bMoveToBB.Text = ">>";
            this.bMoveToBB.UseVisualStyleBackColor = true;
            this.bMoveToBB.Click += new System.EventHandler(this.bMoveToBB_Click);
            // 
            // bMoveToA
            // 
            this.bMoveToA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMoveToA.Location = new System.Drawing.Point(104, 103);
            this.bMoveToA.Name = "bMoveToA";
            this.bMoveToA.Size = new System.Drawing.Size(50, 23);
            this.bMoveToA.TabIndex = 4;
            this.bMoveToA.Text = "<";
            this.bMoveToA.UseVisualStyleBackColor = true;
            this.bMoveToA.Click += new System.EventHandler(this.bMoveToA_Click);
            // 
            // bMoveToAA
            // 
            this.bMoveToAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMoveToAA.Location = new System.Drawing.Point(104, 132);
            this.bMoveToAA.Name = "bMoveToAA";
            this.bMoveToAA.Size = new System.Drawing.Size(50, 23);
            this.bMoveToAA.TabIndex = 5;
            this.bMoveToAA.Text = "<<";
            this.bMoveToAA.UseVisualStyleBackColor = true;
            this.bMoveToAA.Click += new System.EventHandler(this.bMoveToAA_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bAdd);
            this.groupBox1.Controls.Add(this.tbAdd);
            this.groupBox1.Controls.Add(this.lbA);
            this.groupBox1.Controls.Add(this.bMoveToAA);
            this.groupBox1.Controls.Add(this.bMoveToA);
            this.groupBox1.Controls.Add(this.lbB);
            this.groupBox1.Controls.Add(this.bMoveToBB);
            this.groupBox1.Controls.Add(this.bMoveToB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 167);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listboxes";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(104, 17);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(50, 23);
            this.bAdd.TabIndex = 7;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(6, 19);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(92, 20);
            this.tbAdd.TabIndex = 6;
            this.tbAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAdd_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbPeople);
            this.groupBox2.Location = new System.Drawing.Point(286, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 166);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "People";
            // 
            // lbPeople
            // 
            this.lbPeople.FormattingEnabled = true;
            this.lbPeople.Location = new System.Drawing.Point(7, 16);
            this.lbPeople.Name = "lbPeople";
            this.lbPeople.Size = new System.Drawing.Size(114, 134);
            this.lbPeople.TabIndex = 0;
            // 
            // ListBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 185);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListBoxForm";
            this.Text = "ListBoxes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbA;
        private System.Windows.Forms.ListBox lbB;
        private System.Windows.Forms.Button bMoveToB;
        private System.Windows.Forms.Button bMoveToBB;
        private System.Windows.Forms.Button bMoveToA;
        private System.Windows.Forms.Button bMoveToAA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbPeople;
    }
}

