namespace BookStore
{
    partial class FormBook
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
            this.tabBook = new System.Windows.Forms.TabControl();
            this.tbpBook = new System.Windows.Forms.TabPage();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbSciFi = new System.Windows.Forms.RadioButton();
            this.rbLiterature = new System.Windows.Forms.RadioButton();
            this.rbHistorical = new System.Windows.Forms.RadioButton();
            this.tbPageNumber = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpHistorical = new System.Windows.Forms.TabPage();
            this.cbCentury = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMainCharacter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpLiterature = new System.Windows.Forms.TabPage();
            this.tbTranslator = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbpSciFi = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tbWorld = new System.Windows.Forms.TextBox();
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tabBook.SuspendLayout();
            this.tbpBook.SuspendLayout();
            this.gbType.SuspendLayout();
            this.tbpHistorical.SuspendLayout();
            this.tbpLiterature.SuspendLayout();
            this.tbpSciFi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBook
            // 
            this.tabBook.Controls.Add(this.tbpBook);
            this.tabBook.Controls.Add(this.tbpHistorical);
            this.tabBook.Controls.Add(this.tbpLiterature);
            this.tabBook.Controls.Add(this.tbpSciFi);
            this.tabBook.Location = new System.Drawing.Point(4, 12);
            this.tabBook.Name = "tabBook";
            this.tabBook.SelectedIndex = 0;
            this.tabBook.Size = new System.Drawing.Size(337, 161);
            this.tabBook.TabIndex = 0;
            this.tabBook.Tag = "1";
            // 
            // tbpBook
            // 
            this.tbpBook.Controls.Add(this.tbPrice);
            this.tbpBook.Controls.Add(this.label8);
            this.tbpBook.Controls.Add(this.gbType);
            this.tbpBook.Controls.Add(this.tbPageNumber);
            this.tbpBook.Controls.Add(this.tbTitle);
            this.tbpBook.Controls.Add(this.tbAuthor);
            this.tbpBook.Controls.Add(this.label3);
            this.tbpBook.Controls.Add(this.label2);
            this.tbpBook.Controls.Add(this.label1);
            this.tbpBook.Location = new System.Drawing.Point(4, 22);
            this.tbpBook.Name = "tbpBook";
            this.tbpBook.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBook.Size = new System.Drawing.Size(329, 135);
            this.tbpBook.TabIndex = 0;
            this.tbpBook.Text = "Book";
            this.tbpBook.UseVisualStyleBackColor = true;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(89, 94);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 8;
            this.tbPrice.Text = "0";
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOnlyNumber_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Price:";
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbSciFi);
            this.gbType.Controls.Add(this.rbLiterature);
            this.gbType.Controls.Add(this.rbHistorical);
            this.gbType.Location = new System.Drawing.Point(222, 20);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(89, 91);
            this.gbType.TabIndex = 6;
            this.gbType.TabStop = false;
            this.gbType.Text = "Type";
            // 
            // rbSciFi
            // 
            this.rbSciFi.AutoSize = true;
            this.rbSciFi.Location = new System.Drawing.Point(6, 65);
            this.rbSciFi.Name = "rbSciFi";
            this.rbSciFi.Size = new System.Drawing.Size(51, 17);
            this.rbSciFi.TabIndex = 2;
            this.rbSciFi.TabStop = true;
            this.rbSciFi.Text = "Sci-Fi";
            this.rbSciFi.UseVisualStyleBackColor = true;
            this.rbSciFi.CheckedChanged += new System.EventHandler(this.radioButtonCommon_CheckedChanged);
            // 
            // rbLiterature
            // 
            this.rbLiterature.AutoSize = true;
            this.rbLiterature.Location = new System.Drawing.Point(6, 42);
            this.rbLiterature.Name = "rbLiterature";
            this.rbLiterature.Size = new System.Drawing.Size(69, 17);
            this.rbLiterature.TabIndex = 1;
            this.rbLiterature.TabStop = true;
            this.rbLiterature.Text = "Literature";
            this.rbLiterature.UseVisualStyleBackColor = true;
            this.rbLiterature.CheckedChanged += new System.EventHandler(this.radioButtonCommon_CheckedChanged);
            // 
            // rbHistorical
            // 
            this.rbHistorical.AutoSize = true;
            this.rbHistorical.Location = new System.Drawing.Point(6, 19);
            this.rbHistorical.Name = "rbHistorical";
            this.rbHistorical.Size = new System.Drawing.Size(68, 17);
            this.rbHistorical.TabIndex = 0;
            this.rbHistorical.TabStop = true;
            this.rbHistorical.Text = "Historical";
            this.rbHistorical.UseVisualStyleBackColor = true;
            this.rbHistorical.CheckedChanged += new System.EventHandler(this.radioButtonCommon_CheckedChanged);
            // 
            // tbPageNumber
            // 
            this.tbPageNumber.Location = new System.Drawing.Point(89, 68);
            this.tbPageNumber.Name = "tbPageNumber";
            this.tbPageNumber.Size = new System.Drawing.Size(100, 20);
            this.tbPageNumber.TabIndex = 5;
            this.tbPageNumber.Text = "0";
            this.tbPageNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOnlyNumber_KeyPress);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(89, 40);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 20);
            this.tbTitle.TabIndex = 4;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(89, 13);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(100, 20);
            this.tbAuthor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PageNumber:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author:";
            // 
            // tbpHistorical
            // 
            this.tbpHistorical.Controls.Add(this.cbCentury);
            this.tbpHistorical.Controls.Add(this.label5);
            this.tbpHistorical.Controls.Add(this.tbMainCharacter);
            this.tbpHistorical.Controls.Add(this.label4);
            this.tbpHistorical.Location = new System.Drawing.Point(4, 22);
            this.tbpHistorical.Name = "tbpHistorical";
            this.tbpHistorical.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHistorical.Size = new System.Drawing.Size(329, 135);
            this.tbpHistorical.TabIndex = 1;
            this.tbpHistorical.Text = "Historical";
            this.tbpHistorical.UseVisualStyleBackColor = true;
            // 
            // cbCentury
            // 
            this.cbCentury.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCentury.FormattingEnabled = true;
            this.cbCentury.Location = new System.Drawing.Point(104, 46);
            this.cbCentury.Name = "cbCentury";
            this.cbCentury.Size = new System.Drawing.Size(121, 21);
            this.cbCentury.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Century:";
            // 
            // tbMainCharacter
            // 
            this.tbMainCharacter.Location = new System.Drawing.Point(104, 17);
            this.tbMainCharacter.Name = "tbMainCharacter";
            this.tbMainCharacter.Size = new System.Drawing.Size(121, 20);
            this.tbMainCharacter.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Main character:";
            // 
            // tbpLiterature
            // 
            this.tbpLiterature.Controls.Add(this.tbTranslator);
            this.tbpLiterature.Controls.Add(this.label6);
            this.tbpLiterature.Location = new System.Drawing.Point(4, 22);
            this.tbpLiterature.Name = "tbpLiterature";
            this.tbpLiterature.Size = new System.Drawing.Size(329, 135);
            this.tbpLiterature.TabIndex = 2;
            this.tbpLiterature.Text = "Literature";
            this.tbpLiterature.UseVisualStyleBackColor = true;
            // 
            // tbTranslator
            // 
            this.tbTranslator.Location = new System.Drawing.Point(88, 17);
            this.tbTranslator.Name = "tbTranslator";
            this.tbTranslator.Size = new System.Drawing.Size(159, 20);
            this.tbTranslator.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Translator:";
            // 
            // tbpSciFi
            // 
            this.tbpSciFi.Controls.Add(this.label7);
            this.tbpSciFi.Controls.Add(this.tbWorld);
            this.tbpSciFi.Location = new System.Drawing.Point(4, 22);
            this.tbpSciFi.Name = "tbpSciFi";
            this.tbpSciFi.Size = new System.Drawing.Size(329, 135);
            this.tbpSciFi.TabIndex = 3;
            this.tbpSciFi.Text = "Sci-Fi";
            this.tbpSciFi.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "World:";
            // 
            // tbWorld
            // 
            this.tbWorld.Location = new System.Drawing.Point(86, 18);
            this.tbWorld.Name = "tbWorld";
            this.tbWorld.Size = new System.Drawing.Size(163, 20);
            this.tbWorld.TabIndex = 0;
            // 
            // bOk
            // 
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOk.Location = new System.Drawing.Point(241, 175);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(100, 23);
            this.bOk.TabIndex = 1;
            this.bOk.Tag = "1";
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(4, 175);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(100, 23);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // FormBook
            // 
            this.AcceptButton = this.bOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(350, 207);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.tabBook);
            this.Name = "FormBook";
            this.Text = "FormBook";
            this.Load += new System.EventHandler(this.FormBook_Load);
            this.tabBook.ResumeLayout(false);
            this.tbpBook.ResumeLayout(false);
            this.tbpBook.PerformLayout();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.tbpHistorical.ResumeLayout(false);
            this.tbpHistorical.PerformLayout();
            this.tbpLiterature.ResumeLayout(false);
            this.tbpLiterature.PerformLayout();
            this.tbpSciFi.ResumeLayout(false);
            this.tbpSciFi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBook;
        private System.Windows.Forms.TabPage tbpBook;
        private System.Windows.Forms.TabPage tbpHistorical;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TabPage tbpLiterature;
        private System.Windows.Forms.TabPage tbpSciFi;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbSciFi;
        private System.Windows.Forms.RadioButton rbLiterature;
        private System.Windows.Forms.RadioButton rbHistorical;
        private System.Windows.Forms.TextBox tbPageNumber;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCentury;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMainCharacter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTranslator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbWorld;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label8;
    }
}