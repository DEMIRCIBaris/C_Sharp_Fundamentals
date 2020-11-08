using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ToTableAttribute:Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
