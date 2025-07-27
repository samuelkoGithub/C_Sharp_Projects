using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Peter", 22, "Maths", 77);

            Console.WriteLine($"{student1.Name}");
            Console.WriteLine($"{student1.Age}");
            Console.WriteLine($"{student1.Subject}");
            Console.WriteLine($"{student1.Grade}");
            //  Console.WriteLine(Console.ReadLine());
            Console.ReadKey();

        }
    }
}
