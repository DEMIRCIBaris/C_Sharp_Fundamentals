using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public interface IPerson
    {
        //Property ve metotlar için sadece imzalar tanımlanır
         int Id { get; set; }
         string FirstName { get; set; }

    }
}
