using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  bool isOn = true;
            bool isHot = false;

            if (isOn)
            {
                Console.WriteLine("The light is on.");
            }

            Console.ReadLine(); */

            bool isAdmin = true;
            bool isLoggedIn = true;

            if (isAdmin)
            {
                Console.WriteLine("Welcome to the site Admin");
            }
            if (isAdmin && isLoggedIn)
            {
                Console.WriteLine("You're logged in, and an Admin!")
            }
            Console.ReadLine();

        }
    }
}
