using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    class CustomerManager
    {
        private int _count=15;

        public CustomerManager(int count)//yapıcı metot tanımı
        {
            this._count = count;
        }

        public CustomerManager()//yapıcının aşırı yüklenmesi
        {

        }

        public void List()
        {
            Console.WriteLine($"{_count} adet müşteri listelendi");
        }

        public void Add()
        {
            Console.WriteLine("Eklendi");
        }
    }
}
