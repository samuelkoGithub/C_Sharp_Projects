using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
           
            FictionBook fb = new FictionBook();

            fb.Title = "隱性潛能";
            fb.Author = "亞當．格蘭特";
            fb.Price = fb.AddTax(379.95);
            fb.Genre = "組織／管理";

            fb.DisplayInfo();

            ComicBook cb = new ComicBook("1984", "George Orwell", 300, 1984);

            cb.DisplayInfo();

            Console.ReadKey();
        }
    }
}
