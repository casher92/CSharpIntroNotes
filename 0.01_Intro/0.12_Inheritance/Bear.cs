using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Inheritance
{
    class Bear : animal
    {
        public bool Hibernate { get; set; }
        public string Meal { get; set; }
        public bool StealsPicnicBaskets { get; set; }

        public void Speak ()
        {
            Console.WriteLine("GRRRRRRRAAWWWW");
        }


    }
}
