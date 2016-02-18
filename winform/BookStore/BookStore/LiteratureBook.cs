using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    class LiteratureBook : Book
    {
        private string fTranslator;

        public string Translator
        {
            get { return this.fTranslator; }
            set { this.fTranslator = value; }
        }

        public LiteratureBook(string translator, string author, string title, int pageNumber, int price)
            : base(author, title, pageNumber, price)
        {
            this.Translator = translator;
        }

        public override string ToString()
        {
            return "[LiteratureBook] " + base.ToString() + " - " + this.Translator;
        }

        public override string Print()
        {
            string sprint = "";
            sprint += "L i t e r a t u r e B o o k\n";
            sprint += "=============================================\n";
            sprint += this.ToString() + "\n";
            sprint += "=============================================\n";
            return sprint;
        }
        
    }
}
