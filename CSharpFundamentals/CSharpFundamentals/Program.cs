using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var students = new string[] { "student1", "student2", "student3" };
                students[3] = "student4";

                Console.WriteLine("Basarılı");
            }
            catch(IndexOutOfRangeException)//Ozel bir hata beklentimiz var ise
            {
                Console.WriteLine("Hata bulundu");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);//Hatayı projeyi durdurmadan gösterir
            }
         

            Console.ReadLine();
        }
    }
}
