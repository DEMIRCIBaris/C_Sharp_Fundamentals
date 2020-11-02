using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public class PersonManager
    {
        public void Add(IPerson person) //Parametre olarak IPerson imzasına sahip her classı verebiliriz
        {
            Console.WriteLine($"{person.FirstName} kaydedildi");
        }
    }
}
