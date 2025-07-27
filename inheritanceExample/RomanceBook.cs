using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceExample
{
    abstract class RomanceBook : Book
    {
        public string FileAdoption;

        public RomanceBook(string title, string author, double price, string filmName) : base(title, author, price)
        {
            FileAdoption = filmName;
        }

        public override void WhichFilmAdoption()
        {
            FileAdoption = "Western Film";
        }
    }
}
