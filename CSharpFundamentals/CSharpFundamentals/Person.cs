using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public class Person
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public virtual void Eat() //Ezilebilir metot yaptık.Farklı bir kullanım gerekirse ezeriz
        {
            Console.WriteLine("Katinden Yemek Ye");
        }
    }
}
