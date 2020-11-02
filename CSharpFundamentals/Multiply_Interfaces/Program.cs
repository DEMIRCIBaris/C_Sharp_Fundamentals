using System;

namespace Multiply_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var workerArray = new IWorker[3]
            {
                new Robots(),
                new Worker(),
                new Manager()
            };

            foreach (var item in workerArray)//Çalışma eylemi için herkese görev verildi
            {
                item.Work();
            }

            var eatArray = new IEat[2]{new Manager(),new Worker() };

            foreach (var item in eatArray) //Yemek eylemi bu eyleme sahip herkes için uygulandı
            {
                item.Eat();
            }
        }
    }
}
