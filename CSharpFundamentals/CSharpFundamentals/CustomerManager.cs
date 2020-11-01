using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    class CustomerManager
    {
        //Properties-->Encapsulation
        public int Id { get; set; }
        public string CustomerName { get; set; }

        //Fields
        private string _firstName;

        //Encapsulation ile Field'lara kontrollü erişim sağlanıyor.
        public string FirstName
        {
            get 
            {
                return "İsminiz: "+_firstName;
            }

            set
            {
                _firstName = value;
            } 
        }


        //Metots
        public void Add()
        {
            Console.WriteLine("Musteri Eklendi");
        }
        public void Update()
        {
            Console.WriteLine("Musteri Guncellendi");
        }
    }
}
