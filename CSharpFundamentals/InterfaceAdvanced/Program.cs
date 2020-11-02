using System;

namespace InterfaceAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            //Tek bir yerden kontrol ederek tek hamlede teknolojiyi değiştirebiliyoruz
            customerManager.Add(new SqlServerCustomerDal()); //Sql Server a ekledi
            customerManager.Add(new PostgreSqlDal()); //Postgre Sql a ekledi

            Console.WriteLine("---------------------------------------------");

            ICustomerDal[] customerDals = new ICustomerDal[2] { new SqlServerCustomerDal(),new PostgreSqlDal()};

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();//Bütün veritabanlarına kayıt işlemi yapıldı
            }

            Console.ReadKey();

        }
    }
}
