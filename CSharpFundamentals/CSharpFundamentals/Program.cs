using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var utilities = new Utilities();

            var numbers = utilities.BuildList<int>(1,2,3,4);
            var cities = utilities.BuildList<string>("İst","Esk","Ank");
            var categories = utilities.BuildList<Category>(new Category { Id=1, CategoryName="Tecn"},new Category {Id=2,CategoryName="Phones"});

        }
    }
}
