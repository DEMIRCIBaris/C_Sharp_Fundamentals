using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3] 
            {
                new Customer(){Id=1,FirstName="Customer",LastName="CLast",Address="Customer City" },
                new Student(){Id=2,FirstName="Student",LastName="SLast",Department="University" },
                new Person(){Id=3,FirstName="Person",LastName="Last" }
            };

            foreach (var person in persons)
            {
                person.Eat();
            }

            
        }
    }
}
