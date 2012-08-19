namespace Dialog
{
    partial class DialogsForm
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
            this.bSimple = new System.Windows.Forms.Button();
            this.bHeader = new System.Windows.Forms.Button();
            this.bUpgrade = new System.Windows.Forms.Button();
            this.bNoModalCustomDialog = new System.Windows.Forms.Button();
            this.bModalCustomDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSimple
            // 
            this.bSimple.Location = new System.Drawing.Point(12, 12);
            this.bSimple.Name = "bSimple";
            this.bSimple.Size = new System.Drawing.Size(219, 23);
            this.bSimple.TabIndex = 0;
            this.bSimple.Text = "MessageBox Simple";
            this.bSimple.UseVisualStyleBackColor = true;
            this.bSimple.Click += new System.EventHandler(this.bSimple_Click);
            // 
            // bHeader
            // 
            this.bHeader.Location = new System.Drawing.Point(12, 41);
            this.bHeader.Name = "bHeader";
            this.bHeader.Size = new System.Drawing.Size(219, 23);
            this.bHeader.TabIndex = 1;
            this.bHeader.Text = "MessageBox Header";
            this.bHeader.UseVisualStyleBackColor = true;
            this.bHeader.Click += new System.EventHandler(this.bHeader_Click);
            // 
            // bUpgrade
            // 
            this.bUpgrade.Location = new System.Drawing.Point(12, 70);
            this.bUpgrade.Name = "bUpgrade";
            this.bUpgrade.Size = new System.Drawing.Size(219, 24);
            this.bUpgrade.TabIndex = 2;
            this.bUpgrade.Text = "MessageBox Upgrade";
            this.bUpgrade.UseVisualStyleBackColor = true;
            this.bUpgrade.Click += new System.EventHandler(this.bUpgrade_Click);
            // 
            // bNoModalCustomDialog
            // 
            this.bNoModalCustomDialog.Location = new System.Drawing.Point(12, 100);
            this.bNoModalCustomDialog.Name = "bNoModalCustomDialog";
            this.bNoModalCustomDialog.Size = new System.Drawing.Size(219, 23);
            this.bNoModalCustomDialog.TabIndex = 3;
            this.bNoModalCustomDialog.Text = "Custom Dialog - no modal";
            this.bNoModalCustomDialog.UseVisualStyleBackColor = true;
            this.bNoModalCustomDialog.Click += new System.EventHandler(this.bNoModalCustomDialog_Click);
            // 
            // bModalCustomDialog
            // 
            this.bModalCustomDialog.Location = new System.Drawing.Point(12, 129);
            this.bModalCustomDialog.Name = "bModalCustomDialog";
            this.bModalCustomDialog.Size = new System.Drawing.Size(219, 23);
            this.bModalCustomDialog.TabIndex = 4;
            this.bModalCustomDialog.Text = "Custom Dialog - modal";
            this.bModalCustomDialog.UseVisualStyleBackColor = true;
            this.bModalCustomDialog.Click += new System.EventHandler(this.bModalCustomDialog_Click);
            // 
            // DialogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 164);
            this.Controls.Add(this.bModalCustomDialog);
            this.Controls.Add(this.bNoModalCustomDialog);
            this.Controls.Add(this.bUpgrade);
            this.Controls.Add(this.bHeader);
            this.Controls.Add(this.bSimple);
            this.Name = "DialogsForm";
            this.Text = "Dialogs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSimple;
        private System.Windows.Forms.Button bHeader;
        private System.Windows.Forms.Button bUpgrade;
        private System.Windows.Forms.Button bNoModalCustomDialog;
        private System.Windows.Forms.Button bModalCustomDialog;
    }
}

