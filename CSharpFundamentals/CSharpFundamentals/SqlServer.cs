using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Sql Serverdan silindi");
        }
    }
}
