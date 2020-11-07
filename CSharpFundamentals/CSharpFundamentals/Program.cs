using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher.Number = 20;//Static olduğu için new'lenmez
            Manager.Validate();//Static metot çağrıldı
            Manager manager = new Manager();
            manager.Message("my message");
        }
    }
}
