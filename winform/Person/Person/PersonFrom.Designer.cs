namespace PersonNamespace
{
  partial class PersonForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bToString = new System.Windows.Forms.Button();
            this.bGetAge = new System.Windows.Forms.Button();
            this.bCreate = new System.Windows.Forms.Button();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.cbSpectacled = new System.Windows.Forms.CheckBox();
            this.tbYearOfBirth = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbFamilyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bToString);
            this.groupBox1.Controls.Add(this.bGetAge);
            this.groupBox1.Controls.Add(this.bCreate);
            this.groupBox1.Controls.Add(this.rbWoman);
            this.groupBox1.Controls.Add(this.rbMan);
            this.groupBox1.Controls.Add(this.cbSpectacled);
            this.groupBox1.Controls.Add(this.tbYearOfBirth);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Controls.Add(this.tbFamilyName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // bToString
            // 
            this.bToString.Enabled = false;
            this.bToString.Location = new System.Drawing.Point(250, 75);
            this.bToString.Name = "bToString";
            this.bToString.Size = new System.Drawing.Size(154, 23);
            this.bToString.TabIndex = 12;
            this.bToString.Text = "ToString()";
            this.bToString.UseVisualStyleBackColor = true;
            this.bToString.Click += new System.EventHandler(this.bToString_Click);
            // 
            // bGetAge
            // 
            this.bGetAge.Enabled = false;
            this.bGetAge.Location = new System.Drawing.Point(250, 46);
            this.bGetAge.Name = "bGetAge";
            this.bGetAge.Size = new System.Drawing.Size(154, 23);
            this.bGetAge.TabIndex = 11;
            this.bGetAge.Text = "getAge()";
            this.bGetAge.UseVisualStyleBackColor = true;
            this.bGetAge.Click += new System.EventHandler(this.bGetAge_Click);
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(250, 16);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(154, 23);
            this.bCreate.TabIndex = 10;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Location = new System.Drawing.Point(140, 123);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(59, 17);
            this.rbWoman.TabIndex = 9;
            this.rbWoman.Text = "woman";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Checked = true;
            this.rbMan.Location = new System.Drawing.Point(140, 99);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(45, 17);
            this.rbMan.TabIndex = 8;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // cbSpectacled
            // 
            this.cbSpectacled.AutoSize = true;
            this.cbSpectacled.Location = new System.Drawing.Point(13, 98);
            this.cbSpectacled.Name = "cbSpectacled";
            this.cbSpectacled.Size = new System.Drawing.Size(80, 17);
            this.cbSpectacled.TabIndex = 7;
            this.cbSpectacled.Text = "Spectacled";
            this.cbSpectacled.UseVisualStyleBackColor = true;
            // 
            // tbYearOfBirth
            // 
            this.tbYearOfBirth.Location = new System.Drawing.Point(82, 72);
            this.tbYearOfBirth.Name = "tbYearOfBirth";
            this.tbYearOfBirth.Size = new System.Drawing.Size(132, 20);
            this.tbYearOfBirth.TabIndex = 6;
            this.tbYearOfBirth.Text = "1972";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(82, 46);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(132, 20);
            this.tbFirstName.TabIndex = 5;
            this.tbFirstName.Text = "Elek";
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // tbFamilyName
            // 
            this.tbFamilyName.Location = new System.Drawing.Point(82, 20);
            this.tbFamilyName.Name = "tbFamilyName";
            this.tbFamilyName.Size = new System.Drawing.Size(132, 20);
            this.tbFamilyName.TabIndex = 4;
            this.tbFamilyName.Text = "Teszt";
            this.tbFamilyName.TextChanged += new System.EventHandler(this.tbFamilyName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year of birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Family name:";
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 182);
            this.Controls.Add(this.groupBox1);
            this.Name = "PersonForm";
            this.Text = "Person Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rbWoman;
    private System.Windows.Forms.RadioButton rbMan;
    private System.Windows.Forms.CheckBox cbSpectacled;
    private System.Windows.Forms.TextBox tbYearOfBirth;
    private System.Windows.Forms.TextBox tbFirstName;
    private System.Windows.Forms.TextBox tbFamilyName;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button bToString;
    private System.Windows.Forms.Button bGetAge;
    private System.Windows.Forms.Button bCreate;
  }
}

