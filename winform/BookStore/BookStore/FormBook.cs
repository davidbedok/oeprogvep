using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookStore
{
    public enum OpenMode
    {
        VIEW,
        EDIT,
        NEW
    }

    public partial class FormBook : Form
    {
        private OpenMode openMode;

        public FormBook(OpenMode openMode)
            : base()
        {
            this.openMode = openMode;
            InitializeComponent();
            foreach (string cent in Enum.GetNames(typeof(Century))) {
                this.cbCentury.Items.Add(cent);
            }
            this.cbCentury.SelectedIndex = 0;
        }

        private void DisableByTag(Control c)
        {
            int tp = 0;            
            if (c.Tag != null)
            {
                Int32.TryParse(c.Tag.ToString(), out tp);
            }
            if (tp != 1)
            {
                c.Enabled = false;
            }  
        }

        // Disable Form Controls and its SubControls except Tag == 1
        private void DisableControls()
        {            
            foreach (Control c in this.Controls) {
                this.DisableByTag(c);                              
                foreach (Control sc in c.Controls) {
                    this.DisableByTag(sc);                    
                }
            }
            this.bCancel.Visible = false;
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            if (OpenMode.NEW.Equals(this.openMode))
            {
                this.rbHistorical.Checked = true;
                this.Text = "Add new book";
            }
            else
            {
                this.Text = this.ActBook.ToString();
            }
        }

        private void ShowHideTabs()
        {
            this.tabBook.TabPages.Remove(this.tbpHistorical);
            this.tabBook.TabPages.Remove(this.tbpLiterature);
            this.tabBook.TabPages.Remove(this.tbpSciFi);
            if (this.rbHistorical.Checked)
            {
                this.tabBook.TabPages.Add(this.tbpHistorical);
            }
            if (this.rbLiterature.Checked)
            {
                this.tabBook.TabPages.Add(this.tbpLiterature);
            }
            if (this.rbSciFi.Checked)
            {
                this.tabBook.TabPages.Add(this.tbpSciFi);
            }
        }

        // common eventhandler for each radiobutton
        private void radioButtonCommon_CheckedChanged(object sender, EventArgs e)
        {
            this.ShowHideTabs();
        }

        private bool IsNumberInRange(int val, int min, int max)
        {
            return (val >= min && val <= max);
        }

        // common eventhandler for pagenumber and price
        private void textBoxOnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsNumberInRange((int)e.KeyChar, 48, 57) &&
                (int)e.KeyChar != (int)Keys.Back &&
                (int)e.KeyChar != (int)Keys.Delete)
            {
                e.Handled = true;
            }            
        }

        private string getMemberText( TextBox tb )
        {
            if (!tb.Text.Equals("")) {
                return tb.Text;
            } else {
                return "no " + tb.Name;
            }
        }

        protected string Author
        {
            get { return this.getMemberText(this.tbAuthor); }
        }

        protected string Title
        {
            get { return this.getMemberText(this.tbTitle); }
        }

        protected int PageNumber
        {
            get { return Convert.ToInt32(this.tbPageNumber.Text); }
        }

        protected int Price
        {
            get { return Convert.ToInt32(tbPrice.Text); }
        }

        protected string MainCharacter
        {
            get { return this.getMemberText(this.tbMainCharacter); }
        }

        protected string Translator
        {
            get { return this.getMemberText(this.tbTranslator); }
        }

        protected string World
        {
            get { return this.getMemberText(this.tbWorld); }
        }

        protected Century BookCentury
        {
            get { return (Century)Enum.Parse(typeof(Century), cbCentury.Text); }
        }

        // get or set the Book
        public Book ActBook
        { 
            get {
                Book iBook = null;
                if (this.rbHistorical.Checked) {
                    iBook = new HistoricalBook(MainCharacter, BookCentury, Author, Title, PageNumber, Price);
                }
                if (this.rbLiterature.Checked)
                {
                    iBook = new LiteratureBook(Translator, Author, Title, PageNumber, Price);
                }
                if (this.rbSciFi.Checked)
                {
                    iBook = new SciFiBook(World, Author, Title, PageNumber, Price);
                }
                return iBook;
            }
            set
            {
                this.tbAuthor.Text = value.Author;
                this.tbTitle.Text = value.Title;
                this.tbPageNumber.Text = value.PageNumber.ToString();
                this.tbPrice.Text = value.Price.ToString();
                this.rbHistorical.Checked = false;
                this.rbLiterature.Checked = false;
                this.rbSciFi.Checked = false;
                if (value is HistoricalBook) {
                    this.tbMainCharacter.Text = (value as HistoricalBook).MainHistCharacter;
                    this.cbCentury.Text = (value as HistoricalBook).Century.ToString();
                    this.rbHistorical.Checked = true;
                }
                if (value is LiteratureBook) {
                    this.tbTranslator.Text = (value as LiteratureBook).Translator;
                    this.rbLiterature.Checked = true;
                }
                if (value is SciFiBook) {
                    this.tbWorld.Text = (value as SciFiBook).World;
                    this.rbSciFi.Checked = true;
                }
                if (OpenMode.VIEW.Equals(this.openMode))
                {
                    this.DisableControls();
                }
                if (OpenMode.EDIT.Equals(this.openMode))
                {
                    this.gbType.Enabled = false;
                }
            }
        }




    }
}