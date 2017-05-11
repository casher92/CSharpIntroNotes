using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            student devon = new student();
            devon.FirstName = "Devon";
            devon.LastName = "Peetz";
            devon.Age = 25
        }


        student shelby = new student("Shelby");
    }
}
