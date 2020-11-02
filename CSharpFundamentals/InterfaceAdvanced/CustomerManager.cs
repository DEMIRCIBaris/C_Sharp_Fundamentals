using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAdvanced
{
    public class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add(); //Metot imzasının ekleme komutu.Biz bunu instance'lar ile manipüle edeceğiz.
        }
    }
}
