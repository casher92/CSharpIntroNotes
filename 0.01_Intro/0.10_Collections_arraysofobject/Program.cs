using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Collections_arraysofobject
{
    class Program
    {
        static void Main(string[] args)
        {
            Country[] countries = new Country[10];
            countries[0] = new Country("Honduras", "Tegucigalpa");
            countries[1] = new Country("Italy", "Rome");
            countries[2] = new Country("Usa", "Washington D.C.");
            countries[3] = new Country("Peru", "Lima");
            countries[4] = new Country("Israel", "Jerusalem");
            countries[5] = new Country("Japan", "Tokyo");
            countries[6] = new Country("Australia", "Sydney");
            countries[7] = new Country("Nicuragua", "Managua");
            countries[8] = new Country("China", "Bejing");
            countries[9] = new Country("South Korea", "Seoul");

            foreach(var country in countries)
            {
                country.PrintCountryDetails();
            }
            Console.ReadLine();
        }
    }
}
