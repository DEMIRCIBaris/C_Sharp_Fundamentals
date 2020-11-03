using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new CustomerManager(50);
            customer.List();

            var customer2 = new CustomerManager();//Aşırı yüklenmiş yapıcı metot kullanıldı
            customer2.List();
        }
    }
}
