using System;
using System.Linq;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 30;
            int outNumber;

            NumberChange(number); //number deger tip olduğu için parametre olarak 30 gider.number değişkeninin içeriği değişmez

            NumberChangeRef(ref number); //ref ile referansına müdahale ettiğimiz için değişkende değişti

            NumberChangeOut(out outNumber);//out ile tanımlarsak değişkene ilk değer ataması yapmamıza gerek yoktur.

            Add(50, 80);

            DefaultAdd(50);

            var multipleParams = AddParams(3,4,5,6,7);//istediğimiz kadar int parametre yollayabiliriz
        }

        static void Add(int sayi1,int sayi2) //Parametreli
        {
            Console.WriteLine(sayi1+sayi2);
        }
        static void DefaultAdd(int sayi1, int sayi2=100) //Default Parametreli -->default deger ya da degeler sonda ya da sonlarda olmalı
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        static void NumberChange(int number)
        {
            number = 40;
        }
        static void NumberChangeRef(ref int number)
        {
            number = 20;
        }
        static void NumberChangeOut(out int number)
        {
            number = 20;
        } //Metot içerisinde out tanımlı değişkene metot gövdesinde değer ataması yapmamız lazım.

        //Metot Overloading
        static int Multiple(int number1,int number2)
        {
            return number1 * number2;
        } //Metot isimleri aynı fakat metot imzası farklı olduğu için problem yaşamadık
        static int Multiple(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }
        //Metot Overloading

        static int AddParams(params int[] numbers)
        {
            return numbers.Sum();
        } //Params kullanımı



    }
}
