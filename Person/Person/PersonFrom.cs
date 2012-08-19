using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonNamespace
{
    public partial class PersonForm : Form
    {

        private Person person;

        public PersonForm()
        {
            InitializeComponent();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            this.person = new Person(this.tbFamilyName.Text, this.tbFirstName.Text);
            this.person.YearOfBirth = Convert.ToInt32(this.tbYearOfBirth.Text);
            this.person.Spectacled = cbSpectacled.Checked;
            if (rbMan.Checked)
            {
                this.person.Sex = SexType.man;
            }
            else
            {
                this.person.Sex = SexType.women;
            }

            tbFirstName.Tag = this.person;

            bToString.Enabled = true;
            bGetAge.Enabled = true;
            tbYearOfBirth.Enabled = false;
            cbSpectacled.Enabled = false;
            rbMan.Enabled = false;
            rbWoman.Enabled = false;
            bCreate.Enabled = false;
        }

        private void bGetAge_Click(object sender, EventArgs e)
        {
            if (this.person != null)
            {
                MessageBox.Show(person.getAge().ToString(), "Person age");
            }
        }

        private void bToString_Click(object sender, EventArgs e)
        {
            if (this.person != null)
            {
                MessageBox.Show(person.ToString(), "Person toString");
            }
        }

        private void tbFamilyName_TextChanged(object sender, EventArgs e)
        {
            if (this.person != null)
            {
                person.FamilyName = this.tbFamilyName.Text;
            }
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Tag is Person)
                {
                    Person person = (Person)textBox.Tag;
                    person.FirstName = tbFirstName.Text;
                }
            }
        }


    }
}
