using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_V2
{
    public class EmployeeManager
    {
        public ILogger Logger { get; set; }

        public EmployeeManager(ILogger _logger) //Doğru yöntem interface yapıcı metotta tanımlanır.Hatanın önüne geçildi.
        {
            Logger = _logger;
        }

        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Added");
        }
    }
}
