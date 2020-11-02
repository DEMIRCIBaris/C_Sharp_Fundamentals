using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var abstracts = new Database[2]
            {
                new SqlServer(),
                new PostgreSql()
            };

            foreach (var item in abstracts)
            {
                item.Add();
                item.Delete();
            }
        }
    }
}
