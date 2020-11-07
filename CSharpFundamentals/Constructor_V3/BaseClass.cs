using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_V3
{
    public class BaseClass
    {
        private string _message;
        
        public BaseClass(string message)
        {
            _message = message;
        }

        public void Message()
        {
            Console.WriteLine(_message);
        }
    }
}
