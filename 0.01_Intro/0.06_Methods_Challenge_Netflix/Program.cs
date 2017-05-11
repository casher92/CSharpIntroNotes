using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods_Challenge_Netflix
{
    class Program
    {
        static void Main(string[] args)
        {
            Netflix TheTeddyBear = new Netflix();
            TheTeddyBear.movieName = "Ted";
            TheTeddyBear.movieGenre = "Comedy";
            TheTeddyBear.movieRating = 4;
            TheTeddyBear.totalMinutes = 94;
            TheTeddyBear.GetSuggestion();
            TheTeddyBear.ShowRunTime();
            Console.WriteLine(TheTeddyBear.ShowWhoWatched("Craig" , "4"));

            

            Netflix FakeSuperHero = new Netflix();
            FakeSuperHero.movieName = "Green Lantern";
            FakeSuperHero.movieGenre = "Action";
            FakeSuperHero.movieRating = 3;
            FakeSuperHero.GetSuggestion();


            Console.ReadLine();
                

        }
    }
}
