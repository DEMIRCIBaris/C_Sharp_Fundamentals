using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_V3
{
     class PersonManager:BaseClass
    {
        public PersonManager(string message) : base(message)//Kalıtım alınan classın yapıcı fonksiyonuna gönderiyoruz
        {
        }

        public void Add()
        {
            Console.WriteLine("Added");
            Message();//Base Classtan geliyor
        }

    }
}
