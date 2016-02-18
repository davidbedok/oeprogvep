using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    public enum Century
    {       
        CenturyX = 10,
        CenturyXI = 11,
        CenturyXII = 12,
        CenturyXIII = 13,
        CenturyXIV = 14,
        CenturyXV = 15,
        CenturyXVI = 16
    }

    class HistoricalBook : Book
    {
        private string fMainHistCharacter;
        private Century fCentury;

        public string MainHistCharacter
        {
            get { return this.fMainHistCharacter; }
            set { this.fMainHistCharacter = value; }
        }

        public Century Century
        {
            get { return this.fCentury; }
            set { this.fCentury = value; }
        }

        public HistoricalBook(string mainHistCharacter, Century century, string author, string title, int pageNumber, int price)
            : base(author, title, pageNumber, price)
        {
            this.MainHistCharacter = mainHistCharacter;
            this.Century = century;
        }

        public override string ToString()
        {
            return "[HistoricalBook] " + base.ToString() + " - " + this.MainHistCharacter + " (" + this.Century.ToString() + ")";
        }

        public override string Print()
        {
            string sprint = "";
            sprint += "H i s t o r i c a l B o o k\n";
            sprint += "=============================================\n";
            sprint += this.ToString() + "\n";
            sprint += "=============================================\n";
            return sprint;
        }
        
    }
}
