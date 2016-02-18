using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    public abstract class Book : System.Object
    {
        public const int FORMAT_LENGTH = 42;

        private string fAuthor;
        private string fTitle;
        private int fPageNumber;
        private int fPrice;

        public string Author
        {
            get { return this.fAuthor; }
            set { this.fAuthor = value; }
        }

        public string Title
        {
            get { return this.fTitle; }
            set { this.fTitle = value; }
        }

        public int PageNumber
        {
            get { return this.fPageNumber; }
            set { this.fPageNumber = value; }
        }

        public int Price
        {
            get { return this.fPrice; }
            set { this.fPrice = value; }
        }

        public Book(string author, string title, int pageNumber, int price)
        {
            this.Author = author;
            this.Title = title;
            this.PageNumber = pageNumber;
            this.Price = price;
        }

        public abstract string Print();        

        public override string ToString()
        {
            return this.Author + ": " + this.Title + " (" + this.PageNumber + " page)";
        }
        
    }
}
