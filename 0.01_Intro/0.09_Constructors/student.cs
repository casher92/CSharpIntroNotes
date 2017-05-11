using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors
{
    class student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Level { get; set; }

        public student()
        {

        }

        public student(string firstName)
        {
            this.FirstName = firstName
        }

        public student (string firstName, string lastName, int age, string level)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            
            
        }
    }
}
