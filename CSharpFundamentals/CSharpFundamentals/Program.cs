using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Monday);
            Console.ReadKey();
        }
    }

    enum Days
    {
        Monday=10,
        Tuesday=20,
        Saturday=30
    }
}
