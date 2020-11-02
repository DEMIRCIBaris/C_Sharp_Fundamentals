using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonManager();

            var customer = new Customer 
            {
                Id=1,
                FirstName="Customer1",
                Address="London"
            };

            var student = new Student
            {
                Id = 2,
                FirstName = "Student1",
                Department = "Computer Science"
            };

            //Parametre olarak IPerson imzası olan instance'ları verdik
            person.Add(customer);
            person.Add(student);

        }
    }
}
