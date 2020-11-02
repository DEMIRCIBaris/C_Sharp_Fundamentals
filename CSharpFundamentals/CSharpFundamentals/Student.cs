using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public class Student: Person//Interface lerde olduğu gibi çoklu tanımlama yapılamaz
    {
        public string Department { get; set; }
    }
}
