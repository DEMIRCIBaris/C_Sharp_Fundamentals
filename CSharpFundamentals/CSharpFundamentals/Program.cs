using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            ArrayList cities = new ArrayList();//Tip Güvenli Değil,DataType belli değilse kullanılabilir
            cities.Add("İstanbul");
            cities.Add("İzmir");
            cities.Add(5);

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(cities[2]);
            Console.WriteLine("----------------------------------------------------------------");
            #endregion

            #region Generic List
            List<int> numbers = new List<int>(); //Tip güvenlidir
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            List<ProductTable> products = new List<ProductTable>();//Complex Type ile de çalışılabilir
            products.Add(new ProductTable { Id=1,ProductName="Lenovo",CategoryName="Computer"});
            products.Add(new ProductTable { Id = 2, ProductName = "IpHone", CategoryName = "Phone" });
            products.Add(new ProductTable { Id =3, ProductName = "Canon Xs", CategoryName = "Camera" });

            foreach (var item in products)
            {
                Console.WriteLine($"ID:{item.Id} Produt:{item.ProductName}  Category:{item.CategoryName}");
            }
            #endregion

            #region Collection Methods
            var count = products.Count;//Liste sayısı

            products.AddRange(new ProductTable[2] { //Çoklu ekleme
                new ProductTable{Id=4,ProductName="XBox",CategoryName="Console"},
                new ProductTable{Id=5,ProductName="Canon C5",CategoryName="Printer"}
            });

            var product = products.Any(i=>i.Id==1);//Var mı Yok mu
            var product_Id = products.Where(i => i.Id == 1).FirstOrDefault();//ID si 1 olan eleman
            
            products.Remove(product_Id);//Geçerli elemanı siler

            products.Clear();//Liste sıfırlanır



            #endregion

            #region Dictionary
            Dictionary<string, string> sozluk = new Dictionary<string, string>();
            sozluk.Add("What", "Ne");
            sozluk.Add("Book", "Kıtap");
            var book=sozluk["Book"]; //Değere ulaşırız

            foreach (var item in sozluk.Keys)//Anahtarları gösterir
            {
                Console.WriteLine(item);
            }
            foreach (var item in sozluk.Values)//Değerleri gösterir
            {
                Console.WriteLine(item);
            }

            //Var mı Yok mu
            var isThereKey = sozluk.ContainsKey("Glass");
            var isThereValue = sozluk.ContainsValue("Bardak");


            #endregion
        }
    }
}
