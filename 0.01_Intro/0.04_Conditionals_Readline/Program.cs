using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_Readline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today 1-5?");
            string feelingNumber = Console.ReadLine();

            if(feelingNumber == "5" || feelingNumber == "4")
            {
                Console.WriteLine("Wow. That's great to hear");

            }
            else if (feelingNumber == "3" || feelingNumber == "2")
            {
                Console.WriteLine("Thats not so good man");

            }
            else
            {
                Console.WriteLine("You need professional help");
            }
                    
            

           

            Console.ReadLine();




        }
    }
}
