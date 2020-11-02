using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public abstract class Database
    {
        public void Add() //Ekleme işlemi her yerde aynı kullanılacak
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();//Hepsi için farkı çalışacak metot
    }
}
