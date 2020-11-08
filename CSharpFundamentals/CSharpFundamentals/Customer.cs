using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CSharpFundamentals
{
    [ToTable("Customers")]//string değeri yapıcı metotta aldık
    public class Customer
    {
       // [RequiredProperty] allow multiple false olduğu için hata verecektir.
        [RequiredProperty]
        public int Id { get; set; }
        [RequiredProperty] //Custom attribute ile Zorunlu tuttuk
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}
