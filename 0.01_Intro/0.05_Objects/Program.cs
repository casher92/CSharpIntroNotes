using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            donuts appleCinn = new donuts();
            appleCinn.Filling = "apple pie";
            appleCinn.isSpecial = false;
            appleCinn.Price = 0.99M;
            appleCinn.Type = "Filled";

            Console.WriteLine(appleCinn.Filling);

            donuts longJohn = new donuts();
            longJohn.Filling = "Bavarian Creme";
            longJohn.isSpecial = true;
            longJohn.Price = 1.25M;
            longJohn.Type = "Filled";

            Console.WriteLine("A longjohn cost about {0:C}", longJohn.Price);
       




            Console.ReadLine();

        }
    }
}
