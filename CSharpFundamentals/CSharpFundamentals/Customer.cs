using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public class Customer:Person//Interface lerde olduğu gibi çoklu tanımlama yapılamaz
    {
        public string Address { get; set; }

        public override void Eat() //Burada kullanımı ezdik
        {
            Console.WriteLine("Lokanta da yemek ye");
            //base.Eat();Kalıtım alınan sınıfın metodunu default olarak çalıştırır
        }
    }
}
