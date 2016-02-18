using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    class SciFiBook : Book
    {
        private string fWorld;

        public string World
        {
            get { return this.fWorld; }
            set { this.fWorld = value; }
        }

        public SciFiBook(string world, string author, string title, int pageNumber, int price)
            : base(author, title, pageNumber, price)
        {
            this.World = world;
        }

        public override string ToString()
        {
            return "[SciFiBook] " + base.ToString() + " - " + this.World;
        }

        public override string Print()
        {
            string sprint = "";
            sprint += "S c i - F i B o o k\n";
            sprint += "=============================================\n";
            sprint += this.ToString() + "\n";
            sprint += "=============================================\n";
            return sprint;
        }

    }
}
