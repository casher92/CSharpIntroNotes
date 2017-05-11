using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_constructors_challenge
{
    class CellPhone
    {

        public CellPhone(string phoneMake, string phoneModel)
        {
            this.PhoneMake = phoneMake;
            this.PhoneModel = phoneModel;
        }   
                
        public int CellPhoneID { get; set; }
        public string PhoneMake { get; set; }
        public string PhoneModel { get; set; }


        public void PrintToScreen()
        {
            Console.WriteLine("i own an " + PhoneMake + " " + PhoneModel);
        }
            

    
    }





}
