using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Inheritance
{
    class dog : animal
    {
        public bool Rest { get; set; }
        public bool Play { get; set; }
        public string Eat { get; set; }

        public void Talk()
        {
            Console.WriteLine("Squirrel");
        }
    }
}
