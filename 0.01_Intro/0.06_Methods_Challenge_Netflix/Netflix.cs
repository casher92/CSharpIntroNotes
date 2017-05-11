using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods_Challenge_Netflix
{
    class Netflix
    {

        //properties
        public string movieName { get; set; }
        public string movieGenre { get; set; }
        public int movieRating { get; set; }
        public int totalMinutes { get; set; }



        /// <summary>
        /// With no return
        /// </summary>
        //methods
        public void GetSuggestion()
        {
            if (this.movieRating >= 4)
                Console.WriteLine("You need to watch this show!");
            else
                Console.WriteLine("Do not waste your time");
                
        }
        /// <summary>
        /// Methods that return a value
        /// </summary>
        /// <returns></returns>
        public int ShowRunTime()
        {
            Console.WriteLine(this.movieName+ " is " + this.totalMinutes + " minutes long ");
            return this.totalMinutes;
        }

        ///Methods that have parameters
        
        public string ShowWhoWatched(string username, string time)
        {
            string details = username + " watched this at " + time
            return details;
        }

      

    }
    

}
