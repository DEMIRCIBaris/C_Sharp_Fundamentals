﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Department { get; set; }
    }
}
