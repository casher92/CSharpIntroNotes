using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("cats", "annoying creature");
            dictionary.Add("dogs", "mans best friend");

            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                Console.WriteLine("{0} are a {1}", pair.Key, pair.Value);
            }

            
            //Bronze Challenge
            Dictionary<string, string> dictionaryXl = new Dictionary<string, string>();
            dictionaryXl.Add("2000", "Gladiator");
            dictionaryXl.Add("2001", "A Beautiful Mind");
            dictionaryXl.Add("2002", "Chicago");
            dictionaryXl.Add("2003", "Lord of the Rings: Return of the King");
            dictionaryXl.Add("2004", "Million Dollar Baby");
            dictionaryXl.Add("2005", "Crash");

            /* foreach (KeyValuePair<string, string> pair in dictionaryXl)
             {
                 Console.WriteLine("{0} won best picture, and it was made by {1}", pair.Key, pair.Value);
             }   */

              Dictionary<string, string[]> bestPictureNoms = new Dictionary<string, string[]>();

              bestPictureNoms.Add("2000", new string[] { "Gladiator", "Chocolate", "Crouching Tiger Hidden Dragon",});
              bestPictureNoms.Add("2001", new string[] { "Beautiful Mind", "Gosford Park", "In the Bedroom" });
              bestPictureNoms.Add("2002", new string[] { "Chicago", "Gangs of New York", "Harry Potter CS" });

              foreach(KeyValuePair<string, string[]> bestPictureNom in bestPictureNoms)
              {
                 Console.WriteLine("{0}: {1}, {2}, {3}", bestPictureNom.Key, bestPictureNom.Value[0], bestPictureNom.Value[1], bestPictureNom.Value[2]);
              }

              //todo 

            Console.WriteLine(dictionaryXl["2002"]);
            Console.WriteLine("Please type a year to show the movie that won");
            string input1 = Console.ReadLine();

            if (dictionaryXl.ContainsKey(input1))
            {
                string valueForKey = dictionaryXl[input1];
                Console.WriteLine("The best picture in " + input1 + " was " + valueForKey );
            }

            Console.WriteLine("Please type the year to show the movies that were up for an award that year");
            string input2 = Console.ReadLine();

            if (bestPictureNoms.ContainsKey(input2))
            {
                string[] valueForKey = bestPictureNoms[input2];
                string nomineeString = string.Join(", ", valueForKey);
                Console.WriteLine("The best nominees in " + input2 + " were " + nomineeString );
            }


            Console.ReadLine();








          













              





        

           



        }
    }
}
