using System;

namespace CSharpFundamentals
{
    public delegate void MyDelegate();//void dönen ve parametre almayan operasyonları tutabilir
    public delegate void MyDelegate2(string text);//string parametre alan delege
    public delegate int MyDelegate3(int sayi, int sayi2);

    class Program
    {

        static void Main(string[] args)
        {
            var customer = new CustomerManager();
            MyDelegate myDelegate = customer.SendMessage;//MyDeleate türündeki delegeye metot atandı.
            myDelegate += customer.Alert;//Delegeye başka bir metotun işlevi de eklendi
            myDelegate -= customer.SendMessage;//Delegeden görev alındı
            myDelegate(); //Delege çalıştırıldı

            MyDelegate2 myDelegate2 = customer.ViewMessage;
            myDelegate2("Mesaj");

            MyDelegate3 myDelegate3 = customer.Topla;
            Console.WriteLine(myDelegate3(1, 2));

            Handle.HandleException( //Farklı delegate örneği
                () => { customer.ThrowError(); } );



        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Mesaj gönderildi");
        }

        public void Alert()
        {
            Console.WriteLine("Be Careful!!");
        }

        public void ViewMessage(string message)
        {
            Console.WriteLine(message);
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void ThrowError()
        {
            throw new Exception("Hata");
        }

    }

    public static class Handle
    {
        public static void HandleException(Action action) //Action parametresiz void metotlar için kullanılır
        {
            try
            {
                action.Invoke();//Metot çalıştırıldı
            }
            catch (Exception)
            {

                Console.WriteLine("Hata bulundu");
            }
        }

        
    }
}
