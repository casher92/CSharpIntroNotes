using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string occupation;

            firstName = "Craig";
            lastName = "Asher";
            occupation = "Manager";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            Console.WriteLine("Name: {0}" + "\n" + "Occupation: {1}", fullName, occupation);
            Console.ReadLine();
        }
    }
}
