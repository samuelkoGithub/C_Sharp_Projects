using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Student
    {

        /*
         * 
          Property is a member of a class that provides
          flexible mechanism to read, write and compute 
          value of a private field.

          Properties can be used as if they're public data
          members, but they are special methods called 
          accessors.

         */
        /* Add 4 auto-implemented property to the class */
        public string Name { get; set; }  // default value null 
        public int Age { get; set; }  // default 0
        public string Subject { get; set; } // default value null
        public double Grade { get; set; }  // default 0.0

        //Paraeterless constructor
        public Student() 
        { 
        }

        // Parameterized constructor
        public Student(string in_name, int in_age, string in_subject, double in_grade)
        {
            Name = in_name;
            Age = in_age;
            Subject = in_subject;
            Grade = in_grade;
        }

    }
}
