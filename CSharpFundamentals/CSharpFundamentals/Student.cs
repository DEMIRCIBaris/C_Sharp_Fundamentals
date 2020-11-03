using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public class Student:Customer
    {
       public void Save()
        {
            Name = "";//Protected olduğu için tanımlayabildik
            var customer = new Customer();
            customer.Price = 5;//Public olduğu için erişebildik

            
        }
    }
}
