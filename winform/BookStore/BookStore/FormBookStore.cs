using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookStore
{
    public partial class FormBookStore : Form
    {
       
        public FormBookStore()
        {
            InitializeComponent();
            Book iBook1 = new HistoricalBook("Dobo Istvan", Century.CenturyXVI, "Gardonyi Geza", "Egri csillagok", 560, 1500);
            Book iBook2 = new LiteratureBook("Babits Mihaly", "Dante Alighieri", "Isteni szinjatek", 1700, 2500);
            Book iBook3 = new SciFiBook("Arrakis", "Frank Herbert", "Dune", 5432, 1750);
            lbBooks.Items.Add(iBook1);
            lbBooks.Items.Add(iBook2);
            lbBooks.Items.Add(iBook3);
        }

        private void bAddBook_Click(object sender, EventArgs e)
        {
            FormBook iFormBook = new FormBook(OpenMode.NEW);
            DialogResult iDR = iFormBook.ShowDialog();
            if (iDR == DialogResult.OK) {
                this.lbBooks.Items.Add(iFormBook.ActBook);
            }
        }

        private void viewBook_Click(object sender, EventArgs e)
        {
            if (this.lbBooks.SelectedIndex != -1)
            {
                FormBook iFormBook = new FormBook(OpenMode.VIEW);
                iFormBook.ActBook = (Book)this.lbBooks.Items[this.lbBooks.SelectedIndex];
                iFormBook.ShowDialog();                
            }
        }

        // call an other event --> this method is unnecessary
        private void lbBooks_DoubleClick(object sender, EventArgs e)
        {
            this.viewBook_Click(sender, e);
        }

        // use in ListBox Click as well
        private void bPrint_Click(object sender, EventArgs e)
        {
            if (this.lbBooks.SelectedIndex != -1)
            {
                this.rtbPrint.Text = ((Book)this.lbBooks.Items[this.lbBooks.SelectedIndex]).Print();                
            }
        }
        
        private void bBuy_Click(object sender, EventArgs e)
        {
            if (this.lbBooks.SelectedIndex != -1)
            {
                this.lbBasket.Items.Add(this.lbBooks.Items[this.lbBooks.SelectedIndex]);
            }            
        }

        // SelectionMode --> MultiExtended
        private void bRemove_Click(object sender, EventArgs e)
        {
            while (this.lbBasket.SelectedIndex != -1)
            {
                this.lbBasket.Items.RemoveAt(this.lbBasket.SelectedIndex);
            }            
        }

        private void bCheckout_Click(object sender, EventArgs e)
        {            
            string str = "B i l l\n";
            str += "=".PadLeft(Book.FORMAT_LENGTH,'=') + "\n";
            int allprice = 0;
            for (int i = 0; i < this.lbBasket.Items.Count; i++)
            {
                str += "(" + (i + 1) + ") " + this.lbBasket.Items[i].ToString() + "\n";
                str += ((Book)this.lbBasket.Items[i]).Price.ToString().PadLeft(Book.FORMAT_LENGTH, '.') + "\n";
                allprice += ((Book)this.lbBasket.Items[i]).Price;
            }
            str += "=".PadLeft(Book.FORMAT_LENGTH, '=') + "\n";
            str += "Total item: " + this.lbBasket.Items.Count.ToString().PadLeft(Book.FORMAT_LENGTH - 12, '.') + "\n"; ;
            str += "Total price: " + allprice.ToString().PadLeft(Book.FORMAT_LENGTH - 13, '.') + "\n"; ;
            rtbBill.Text = str;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (this.lbBooks.SelectedIndex != -1)
            {
                FormBook iFormBook = new FormBook(OpenMode.EDIT);
                iFormBook.ActBook = (Book)lbBooks.Items[lbBooks.SelectedIndex];
                DialogResult iDR = iFormBook.ShowDialog();
                if (iDR == DialogResult.OK)
                {
                    this.lbBooks.Items.Insert(this.lbBooks.SelectedIndex, iFormBook.ActBook);
                    this.lbBooks.Items.RemoveAt(this.lbBooks.SelectedIndex);
                }
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (this.lbBooks.SelectedIndex != -1)
            {
                this.lbBooks.Items.RemoveAt(this.lbBooks.SelectedIndex);
            }
        }
    }
}