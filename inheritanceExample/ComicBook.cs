using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceExample
{
    class ComicBook : Book
    {
        public int Year;

        public ComicBook(string title, string author, double price, 
            int year) : base(title, author, price)
        {
            Year = year;
        }

        public override double AddTax(double in_Price)
        {
            return base.AddTax(in_Price + 10);
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Title:　{Title}");
            Console.WriteLine($"Author:　{Author}");
            Console.WriteLine($"Price:　{AddTax(Price)}");
            Console.WriteLine($"Year:　{Year}");
        }

        public override void WhichFilmAdoption()
        {
            Console.WriteLine("Eastern Film Style");
        }
    }
}
