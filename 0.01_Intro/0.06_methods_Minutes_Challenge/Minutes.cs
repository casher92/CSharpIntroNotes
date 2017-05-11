using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_methods_Minutes_Challenge
{
    class Minutes
    {
       
    }

    public int YouHaveLeft(int minutesWatched, int minutesTotal)
    {
      int mintuesLeft = this.minutesWatched - minutesTotal;
        Console.WriteLine("There are " + mintuesLeft + " minutes left in the show");
        return mintuesLeft;

    }









}
