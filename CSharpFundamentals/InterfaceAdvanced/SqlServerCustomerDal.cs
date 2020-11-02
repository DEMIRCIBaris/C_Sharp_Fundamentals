using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAdvanced
{
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Server'a eklendi");
        }
    }
}
