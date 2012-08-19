namespace BookStore
{
    partial class FormBookStore
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
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.bAddBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bBuy = new System.Windows.Forms.Button();
            this.bPrint = new System.Windows.Forms.Button();
            this.bViewBook = new System.Windows.Forms.Button();
            this.rtbPrint = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bCheckout = new System.Windows.Forms.Button();
            this.bRemove = new System.Windows.Forms.Button();
            this.lbBasket = new System.Windows.Forms.ListBox();
            this.rtbBill = new System.Windows.Forms.RichTextBox();
            this.bEdit = new System.Windows.Forms.Button();
            this.ttViewButton = new System.Windows.Forms.ToolTip(this.components);
            this.bDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(6, 48);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(343, 95);
            this.lbBooks.TabIndex = 0;
            this.lbBooks.DoubleClick += new System.EventHandler(this.lbBooks_DoubleClick);
            this.lbBooks.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // bAddBook
            // 
            this.bAddBook.Location = new System.Drawing.Point(6, 19);
            this.bAddBook.Name = "bAddBook";
            this.bAddBook.Size = new System.Drawing.Size(60, 23);
            this.bAddBook.TabIndex = 1;
            this.bAddBook.Text = "Add";
            this.bAddBook.UseVisualStyleBackColor = true;
            this.bAddBook.Click += new System.EventHandler(this.bAddBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bDelete);
            this.groupBox1.Controls.Add(this.bEdit);
            this.groupBox1.Controls.Add(this.bBuy);
            this.groupBox1.Controls.Add(this.bPrint);
            this.groupBox1.Controls.Add(this.bViewBook);
            this.groupBox1.Controls.Add(this.lbBooks);
            this.groupBox1.Controls.Add(this.bAddBook);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books";
            // 
            // bBuy
            // 
            this.bBuy.Location = new System.Drawing.Point(7, 149);
            this.bBuy.Name = "bBuy";
            this.bBuy.Size = new System.Drawing.Size(67, 23);
            this.bBuy.TabIndex = 4;
            this.bBuy.Text = "Buy";
            this.bBuy.UseVisualStyleBackColor = true;
            this.bBuy.Click += new System.EventHandler(this.bBuy_Click);
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(289, 19);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(60, 23);
            this.bPrint.TabIndex = 3;
            this.bPrint.Text = "Print";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // bViewBook
            // 
            this.bViewBook.AccessibleDescription = "double click";
            this.bViewBook.Location = new System.Drawing.Point(72, 19);
            this.bViewBook.Name = "bViewBook";
            this.bViewBook.Size = new System.Drawing.Size(60, 23);
            this.bViewBook.TabIndex = 2;
            this.bViewBook.Text = "View";
            this.ttViewButton.SetToolTip(this.bViewBook, "Double click");
            this.bViewBook.UseVisualStyleBackColor = true;
            this.bViewBook.Click += new System.EventHandler(this.viewBook_Click);
            // 
            // rtbPrint
            // 
            this.rtbPrint.Location = new System.Drawing.Point(376, 21);
            this.rtbPrint.Name = "rtbPrint";
            this.rtbPrint.Size = new System.Drawing.Size(319, 79);
            this.rtbPrint.TabIndex = 3;
            this.rtbPrint.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bCheckout);
            this.groupBox2.Controls.Add(this.bRemove);
            this.groupBox2.Controls.Add(this.lbBasket);
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 181);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basket";
            // 
            // bCheckout
            // 
            this.bCheckout.Location = new System.Drawing.Point(274, 148);
            this.bCheckout.Name = "bCheckout";
            this.bCheckout.Size = new System.Drawing.Size(75, 23);
            this.bCheckout.TabIndex = 2;
            this.bCheckout.Text = "Checkout";
            this.bCheckout.UseVisualStyleBackColor = true;
            this.bCheckout.Click += new System.EventHandler(this.bCheckout_Click);
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(7, 148);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(75, 23);
            this.bRemove.TabIndex = 1;
            this.bRemove.Text = "Remove";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // lbBasket
            // 
            this.lbBasket.FormattingEnabled = true;
            this.lbBasket.Location = new System.Drawing.Point(6, 19);
            this.lbBasket.Name = "lbBasket";
            this.lbBasket.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbBasket.Size = new System.Drawing.Size(348, 121);
            this.lbBasket.TabIndex = 0;
            // 
            // rtbBill
            // 
            this.rtbBill.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBill.Location = new System.Drawing.Point(376, 106);
            this.rtbBill.Name = "rtbBill";
            this.rtbBill.Size = new System.Drawing.Size(319, 275);
            this.rtbBill.TabIndex = 5;
            this.rtbBill.Text = "";
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(138, 19);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(60, 23);
            this.bEdit.TabIndex = 5;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // ttViewButton
            // 
            this.ttViewButton.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttViewButton.ToolTipTitle = "Hint";
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(204, 19);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(60, 23);
            this.bDelete.TabIndex = 6;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // FormBookStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 395);
            this.Controls.Add(this.rtbBill);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rtbPrint);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBookStore";
            this.Text = "Book Store";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button bAddBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bViewBook;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.RichTextBox rtbPrint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bBuy;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.ListBox lbBasket;
        private System.Windows.Forms.RichTextBox rtbBill;
        private System.Windows.Forms.Button bCheckout;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.ToolTip ttViewButton;
        private System.Windows.Forms.Button bDelete;
    }
}

