using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public class Customer
    {
        int Id; //Field defaul private
        protected string Name { get; set; } //Sadece Child Classlar görebilir
        public int Price { get; set; }//Herkes görebilir

        public void Save()
        {
            var lesson = new Lesson();
            
        }


    }
}
