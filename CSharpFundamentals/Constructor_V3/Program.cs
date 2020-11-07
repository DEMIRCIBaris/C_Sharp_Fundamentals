using System;

namespace Constructor_V3
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonManager("Message");
            person.Add();
        }
    }
}
