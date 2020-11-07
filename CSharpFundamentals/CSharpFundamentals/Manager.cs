using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public class Manager //Normal bir classta static öğeler kullanılabilir ama tam tersi olamaz
    {
        public static void Validate()
        {
            Console.WriteLine("Validasyon Yapıldı");
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
