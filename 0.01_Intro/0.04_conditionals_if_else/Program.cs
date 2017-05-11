using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_conditionals_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            bool elevatorUp = true;
            bool elevatorDown = true;
            bool elevatorBroken = true;
            bool elevatorStuckWithUsInIt = true;
            int elevatorNumber = 13;
            

            if (elevatorUp == true)
            {
                Console.WriteLine("Going Up");
            }
            else
            {
                Console.WriteLine("Going Down");
            }

           

            if (elevatorBroken)
            {
                Console.WriteLine("PANIC!!!!");

            }
            else
            {
                Console.WriteLine("This is a nice elevator");

            }
            if (elevatorStuckWithUsInIt)
            {
                Console.WriteLine("Let's go die hard in this elevator shaft!!!");
                Console.WriteLine("Yeah let's climb the cord");
            }
            else
            {
                Console.WriteLine("Do you have those TPS reports for me?");
            }

            if (elevatorBroken && elevatorDown)
            {
                Console.WriteLine("Weeeeeeee!!!");
            }
            else
            {
                Console.WriteLine("Man I wish this was broken");
            }

            if (elevatorBroken || elevatorStuckWithUsInIt)
            {
                Console.WriteLine("Dude, we're in Mexico. We're in the 4th grade.");
            }
            else
            {
                Console.WriteLine("Bro this is trash");
            }

            if (elevatorNumber == 13)
            {
                Console.WriteLine("Devil is happening");
            }

            Console.ReadLine();
        }
    }
}
