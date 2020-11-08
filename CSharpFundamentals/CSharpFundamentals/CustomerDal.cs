using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public class CustomerDal
    {
        [Obsolete("Kullanmayınız")]//Metot kullanılmasın diye metoda attribute verdik,uyarı mesajımızı içeride belirledik
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.Name} {customer.Age} özelliklerine sahip müşteri eklendi");
        }


        public void AddNew(Customer customer)
        {
            Console.WriteLine($"{customer.Name} {customer.Age} özelliklerine sahip müşteri eklendi");
        }
    }
}
