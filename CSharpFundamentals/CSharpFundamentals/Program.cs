using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var tip = typeof(DostIslem);
            var dortIslem = (DostIslem)Activator.CreateInstance(tip,6,7); //new DortIslem() ile aynıdır yapıcı metot parametrelerini yanında verdik
            Console.WriteLine(dortIslem.Topla(4,5));
            Console.WriteLine(dortIslem.Topla2());

            MethodInfo info = dortIslem.GetType().GetMethod("Topla2");//Metot Info alındı
            var value=info.Invoke(dortIslem,null);//Metodu çalıştırdı
            Console.WriteLine(value);

            var metotlar = dortIslem.GetType().GetMethods(); //Tüm metotlar
            foreach (var item in metotlar)
            {
                Console.WriteLine(item.Name);
                foreach (var attribute in item.GetCustomAttributes())
                {
                    Console.WriteLine($"Attribut Name {attribute.GetType().Name}"); //Attribute'a ulaştık
                }
                Console.WriteLine("--------------------------------------------");
            }

        }
    }

    public class DostIslem
    {
        private int sayi1;
        private int sayi2;

        public DostIslem(int sayi1,int sayi2)
        {
            this.sayi1 = sayi1;
            this.sayi2 = sayi2;
        }

      
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Topla2()
        {
            return sayi2 + sayi1;
        }
    }
}
