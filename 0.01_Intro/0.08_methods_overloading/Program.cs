using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_methods_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            player JSWizard = new player();
            JSWizard.Name = "The self-proclaimed JS Wizard";
            JSWizard.Attack();
            JSWizard.Attack("Dusty Wand");
            JSWizard.Attack("Dusty Wand", 1);
            Console.ReadLine();
        }
    }
}
