using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
}
