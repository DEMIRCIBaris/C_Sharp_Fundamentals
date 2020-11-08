using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer { Id = 1, Name = "Customer", Age = 25, Address = "City" };

            var customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
    }
}
