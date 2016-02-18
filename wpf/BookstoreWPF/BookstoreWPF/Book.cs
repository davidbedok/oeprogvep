using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreWPF
{
    public class Book
    {

        private String title;
        private String author;
        private BookCategory category;
        private bool available;

		public String Title {
			get { return this.title; }
			set { this.title = value; }
		}

		public String Author
		{
			get { return this.author; }
			set { this.author = value; }
		}

		public BookCategory Category
		{
			get { return this.category; }
			set { this.category = value; }
		}

		public bool Available
		{
			get { return this.available; }
			set { this.available = value; }
		}

        public Book(String title)
            : this(title, "", BookCategory.UNDEFINED, true)
        {
        }

        public Book( String title, String author, BookCategory category, bool available ) {
            this.title = title;
            this.author = author;
            this.category = category;
            this.available = available;
        }

		public override string ToString()
		{
			String availableInfo = this.available ? " available" : "";
			return this.author + ": " + this.title + " (" + this.category + ")" + availableInfo;
		}

    }
}
