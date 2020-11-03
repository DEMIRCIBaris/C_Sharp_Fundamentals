using System;

namespace Constructor_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager manager = new EmployeeManager(new DatabaseLogger());
            manager.Add();
        }
    }
}
