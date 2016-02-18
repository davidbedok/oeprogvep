namespace Restaurant
{
    partial class FormRest
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
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.tbMenuDesk = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFood = new System.Windows.Forms.ListBox();
            this.bMenuAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bOrderRemove = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbFood = new System.Windows.Forms.TextBox();
            this.bAddNewFood = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.lbBill = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bPrint = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDesk = new System.Windows.Forms.ComboBox();
            this.lbPrice = new System.Windows.Forms.ListBox();
            this.lbDesk = new System.Windows.Forms.ListBox();
            this.tbTip = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.tbMenuDesk);
            this.gbMenu.Controls.Add(this.label8);
            this.gbMenu.Controls.Add(this.label2);
            this.gbMenu.Controls.Add(this.label1);
            this.gbMenu.Controls.Add(this.lbFood);
            this.gbMenu.Controls.Add(this.bMenuAdd);
            this.gbMenu.Location = new System.Drawing.Point(12, 12);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(203, 298);
            this.gbMenu.TabIndex = 0;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Menu";
            // 
            // tbMenuDesk
            // 
            this.tbMenuDesk.Location = new System.Drawing.Point(47, 13);
            this.tbMenuDesk.Name = "tbMenuDesk";
            this.tbMenuDesk.Size = new System.Drawing.Size(65, 20);
            this.tbMenuDesk.TabIndex = 16;
            this.tbMenuDesk.Text = "A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Desk:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price (huf)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Food";
            // 
            // lbFood
            // 
            this.lbFood.FormattingEnabled = true;
            this.lbFood.Items.AddRange(new object[] {
            "Nyuszifülnövesztõ#300",
            "Gulyás leves#800",
            "Májgombóc leves#650",
            "Jókai bableves#700",
            "Töltött paprika#1200",
            "Rakott krumpli#900",
            "Palacsinta#340",
            "Tiramisu#280"});
            this.lbFood.Location = new System.Drawing.Point(6, 56);
            this.lbFood.Name = "lbFood";
            this.lbFood.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbFood.Size = new System.Drawing.Size(185, 225);
            this.lbFood.TabIndex = 1;
            // 
            // bMenuAdd
            // 
            this.bMenuAdd.Location = new System.Drawing.Point(121, 13);
            this.bMenuAdd.Name = "bMenuAdd";
            this.bMenuAdd.Size = new System.Drawing.Size(70, 23);
            this.bMenuAdd.TabIndex = 0;
            this.bMenuAdd.Text = ">>";
            this.bMenuAdd.UseVisualStyleBackColor = true;
            this.bMenuAdd.Click += new System.EventHandler(this.bMenuAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDesk);
            this.groupBox2.Controls.Add(this.lbPrice);
            this.groupBox2.Controls.Add(this.bOrderRemove);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbPrice);
            this.groupBox2.Controls.Add(this.tbFood);
            this.groupBox2.Controls.Add(this.bAddNewFood);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbOrder);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbEvents);
            this.groupBox2.Location = new System.Drawing.Point(221, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 298);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restaurant";
            // 
            // bOrderRemove
            // 
            this.bOrderRemove.Location = new System.Drawing.Point(62, 14);
            this.bOrderRemove.Name = "bOrderRemove";
            this.bOrderRemove.Size = new System.Drawing.Size(75, 23);
            this.bOrderRemove.TabIndex = 5;
            this.bOrderRemove.Text = "Storno";
            this.bOrderRemove.UseVisualStyleBackColor = true;
            this.bOrderRemove.Click += new System.EventHandler(this.bOrderRemove_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Food";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(273, 70);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 6;
            // 
            // tbFood
            // 
            this.tbFood.Location = new System.Drawing.Point(273, 44);
            this.tbFood.Name = "tbFood";
            this.tbFood.Size = new System.Drawing.Size(100, 20);
            this.tbFood.TabIndex = 5;
            // 
            // bAddNewFood
            // 
            this.bAddNewFood.Location = new System.Drawing.Point(236, 13);
            this.bAddNewFood.Name = "bAddNewFood";
            this.bAddNewFood.Size = new System.Drawing.Size(137, 23);
            this.bAddNewFood.TabIndex = 4;
            this.bAddNewFood.Text = "Add new food";
            this.bAddNewFood.UseVisualStyleBackColor = true;
            this.bAddNewFood.Click += new System.EventHandler(this.bAddNewFood_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Act order";
            // 
            // lbOrder
            // 
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.Location = new System.Drawing.Point(43, 43);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(120, 134);
            this.lbOrder.TabIndex = 2;
            this.lbOrder.SelectedIndexChanged += new System.EventHandler(this.lbOrder_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Events";
            // 
            // lbEvents
            // 
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.Location = new System.Drawing.Point(6, 196);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbEvents.Size = new System.Drawing.Size(367, 95);
            this.lbEvents.TabIndex = 0;
            // 
            // lbBill
            // 
            this.lbBill.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBill.FormattingEnabled = true;
            this.lbBill.ItemHeight = 14;
            this.lbBill.Location = new System.Drawing.Point(13, 41);
            this.lbBill.Name = "lbBill";
            this.lbBill.Size = new System.Drawing.Size(569, 200);
            this.lbBill.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbTip);
            this.groupBox3.Controls.Add(this.bPrint);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbDesk);
            this.groupBox3.Controls.Add(this.lbBill);
            this.groupBox3.Location = new System.Drawing.Point(12, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(588, 251);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bill";
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(178, 13);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(75, 23);
            this.bPrint.TabIndex = 17;
            this.bPrint.Text = "Print";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Desk:";
            // 
            // cbDesk
            // 
            this.cbDesk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDesk.FormattingEnabled = true;
            this.cbDesk.Location = new System.Drawing.Point(51, 13);
            this.cbDesk.Name = "cbDesk";
            this.cbDesk.Size = new System.Drawing.Size(121, 21);
            this.cbDesk.TabIndex = 14;
            // 
            // lbPrice
            // 
            this.lbPrice.Enabled = false;
            this.lbPrice.FormattingEnabled = true;
            this.lbPrice.Location = new System.Drawing.Point(169, 43);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(49, 134);
            this.lbPrice.TabIndex = 13;
            // 
            // lbDesk
            // 
            this.lbDesk.Enabled = false;
            this.lbDesk.FormattingEnabled = true;
            this.lbDesk.Location = new System.Drawing.Point(9, 43);
            this.lbDesk.Name = "lbDesk";
            this.lbDesk.Size = new System.Drawing.Size(28, 134);
            this.lbDesk.TabIndex = 14;
            // 
            // tbTip
            // 
            this.tbTip.Location = new System.Drawing.Point(376, 15);
            this.tbTip.Name = "tbTip";
            this.tbTip.Size = new System.Drawing.Size(42, 20);
            this.tbTip.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tip:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(423, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "%";
            // 
            // FormRest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 579);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbMenu);
            this.Name = "FormRest";
            this.Text = "Restaurant";
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button bOrderRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbFood;
        private System.Windows.Forms.Button bMenuAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbFood;
        private System.Windows.Forms.Button bAddNewFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbEvents;
        private System.Windows.Forms.TextBox tbMenuDesk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbBill;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDesk;
        private System.Windows.Forms.ListBox lbPrice;
        private System.Windows.Forms.ListBox lbDesk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTip;
    }
}

