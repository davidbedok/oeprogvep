using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListBoxes
{
    public partial class ListBoxForm : Form
    {
        private Model model;

        public ListBoxForm()
        {
            InitializeComponent();
            this.model = new Model(2);
            model.addArrayPerson(new Person("Han","Solo"));
            model.addArrayPerson(new Person("Nagy", "Sandor"));
            model.addPerson(new Person("Nemecsek","Erno"));
            model.addPerson(new Person("Darth", "Vader"));
            model.addGenericPerson(new Person("Teszt","Elek"));
            model.addGenericPerson(new Person("Vitez", "Janos"));

            lbPeople.Items.Add(new Person("Toldi","Miklos"));
            lbPeople.Items.AddRange(model.Array);
            lbPeople.Items.AddRange(model.List.ToArray());
            lbPeople.Items.AddRange(model.GenericList.ToArray());
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            this.lbA.Items.Add(tbAdd.Text);
            this.tbAdd.Text = "";
        }

        private void tbAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.bAdd_Click(this,e);
            }
        }

        private void bMoveToB_Click(object sender, EventArgs e)
        {
            // not enough clean code..
           
            for (int i = this.lbA.SelectedItems.Count - 1; i >= 0; i--)
            {
                this.lbB.Items.Add(this.lbA.SelectedItems[i]);
                // this.lbA.Items.Remove(this.lbA.SelectedItems[i]);
                this.lbA.Items.RemoveAt(this.lbA.SelectedIndices[i]);
            }
            
            // onlyCopy();
            // onlyCopy2();
        }

        private void onlyCopy()
        {
            foreach (int index in this.lbA.SelectedIndices)
            {
                this.lbB.Items.Add(this.lbA.Items[index]);
            }
        }

        private void onlyCopy2()
        {
            foreach (var item in this.lbA.SelectedItems)
            {
                this.lbB.Items.Add(item);
            }
        }

        private void bMoveToBB_Click(object sender, EventArgs e)
        {
            // this.lbB.Items.AddRange(this.lbA.Items);
            // this.lbA.Items.Clear();
            this.moveAllItems(this.lbA, this.lbB);
        }

        private void moveAllItems(ListBox from, ListBox to)
        {
            to.Items.AddRange(from.Items);
            from.Items.Clear();
        }

        private void bMoveToA_Click(object sender, EventArgs e)
        {
            // if (this.lbB.SelectedIndex != -1) { }
            // if (this.lbB.SelectedIndices.Count > 0) { }
            if (this.lbB.SelectedItems.Count > 0)
            {
                // this.lbA.Items.Add(this.lbB.SelectedItem);
                this.lbA.Items.Add(this.lbB.Items[this.lbB.SelectedIndex]);
                // this.lbB.Items.Remove(this.lbB.SelectedItem);
                this.lbB.Items.RemoveAt(this.lbB.SelectedIndex);
            }
        }

        private void bMoveToAA_Click(object sender, EventArgs e)
        {
            this.moveAllItems(this.lbB, this.lbA);
        }
    }
}