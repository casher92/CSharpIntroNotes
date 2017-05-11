using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_conditional_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int bankAccount = 50000;
            int debt = 13500;
            int difference = bankAccount - debt;

            int taxSeason = 20000;
            difference = difference - taxSeason;
            
         

            Console.WriteLine(" I have {0:C} in my bank account, and I am {1:C} in debt", bankAccount, debt);
            if(bankAccount >= 7000)
            {
                Console.WriteLine("I have extra money");
            }
            else if (difference < 6999 && difference > 2000)
            {
                Console.WriteLine("We gotta get rid of the dog")
            }
            else
            {
                Console.WriteLine("Looks like I'm living with the 'rents this month");
            }

            Console.ReadLine();
        }
    }
}
