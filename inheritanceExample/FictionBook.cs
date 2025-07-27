using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceExample
{
    class FictionBook:Book
    {
        public string Genre { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title:{Title}");
            Console.WriteLine($"Author:{Author}");
            Console.WriteLine($"Price:{Price:F1}");
            Console.WriteLine($"Genre:{Genre}");
        }

        public override double AddTax(double in_Price)
        {
            return base.AddTax(in_Price+20);
        }
    }
}
