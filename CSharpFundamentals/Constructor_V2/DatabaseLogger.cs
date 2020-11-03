using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_V2
{
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
}
