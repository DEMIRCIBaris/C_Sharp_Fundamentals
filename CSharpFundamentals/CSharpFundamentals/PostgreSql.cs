using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public class PostgreSql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Postgreden silindi");
        }
    }
}
