using System;
using System.Collections.Generic;

namespace SpecialErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Find();
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
          
        }

        private static void Find()
        {
            var students = new List<string>() { "Eray", "Barış", "Berkay" };

            if (!students.Contains("X"))
            {
                throw new RecordNotFoundException();
            }
            else
            {
                Console.WriteLine("Record Found");
            }

        }
    }
}
