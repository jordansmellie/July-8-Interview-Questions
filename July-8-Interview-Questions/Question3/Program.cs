using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Person
    {
        string FirstName;
        string LastName;
        DateTime Birthday;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the person's first name?");
            Console.ReadLine(FirstName);
            FirstName = FirstName.ToUpper;

            Console.WriteLine("What is the person's last name?");
            Console.ReadLine(LastName);
            LastName = LastName.ToUpper;

            Console.WriteLine("What is the person's birthday?");
            Console.ReadLine(Birthday);
        }
    }
}