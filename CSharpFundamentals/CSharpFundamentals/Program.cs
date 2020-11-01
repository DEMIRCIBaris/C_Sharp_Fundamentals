using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new CustomerManager();
            customer.Id = 1;
            customer.CustomerName = "Name1";

            customer.Add();
            customer.Update();


            var customer_1 = new CustomerManager{ Id=2,CustomerName="Name2" };//Farklı bir tanımlama stili
            customer_1.FirstName = "Eray";
            Console.WriteLine(customer_1.FirstName);
        }
    }

    
}
