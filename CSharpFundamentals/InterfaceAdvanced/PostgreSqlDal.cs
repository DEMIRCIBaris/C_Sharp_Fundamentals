using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAdvanced
{
    class PostgreSqlDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Postgre Veritabanına Eklendi");
        }
    }
}
