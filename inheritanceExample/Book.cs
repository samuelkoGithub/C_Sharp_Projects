using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceExample
{
    abstract class Book
    {
        // Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        // Constructor
        public Book()  // Constructor For FictionBook
        {

        }

        public Book(string in_title, string in_author, double in_price)  // Constructor For ComicBook
        {
            Title = in_title;
            Author = in_author;
            Price = in_price;
        }

        public virtual double AddTax(double in_Price)
        {
            return (in_Price * 1.1);
        }

        public abstract void WhichFilmAdoption();

    }
}
