using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Access_Modifiers
{
    class car
    {
        protected string Make { get; set; }
        protected string Model { get; set; }
        protected int Year { get; set; }

        protected string CarDetails()
        {
            return $"Make: {Make} Model: {Model} Year: {Year}";
        }

    }
        
    class Acura : car
    {
        private int price;

        public Acura(string model, int year, int price)
        {
            this.Model = "Acura";
            this.Make = model;
            this.Year = year;
            this.price = price;
        }

        public string AcuraDetails()
        {
            return $"Make {Make}: {Model}: {Year}";
        }




    }









}














/******Keyword***************Applicable To***************Meaning******************************************		
        public 				  Class, Member				No restrictions
        protected			  Member					Access limited to the class and derived classes
        private				  Member					Access limited to the class.

        internal              Class, Member				Access limited to the current assembly		
    protected internal 		  Member					Access limited to current assembly and derived types

**********************************************************************************************************/
