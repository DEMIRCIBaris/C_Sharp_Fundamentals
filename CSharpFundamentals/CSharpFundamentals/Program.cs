using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value
            int number1 = 10;
            int number2 = 20;
            number2 = number1; //Değer aktarımı oluğu için number2 number1 e bağlı olarak değişmez
            number1 = 30;
            Console.WriteLine(number2);

            //Ref
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int[] differentNumber = {100,200,300,400,500,600};

            numbers = differentNumber;//Referans aktarımı
            differentNumber[2] = 700;
            Console.WriteLine(numbers[2]);
        }
    }
}
