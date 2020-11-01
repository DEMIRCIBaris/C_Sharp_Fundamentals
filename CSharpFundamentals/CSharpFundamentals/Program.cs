using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "S1";
            students[1] = "S2";
            students[2] = "S3";

            string[] students_2 = {"S1","S2","S3"};

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            //ÇOK BOYUTLU DİZİLER
            string[,] regions = new string[4, 3] 
            {
                {"S1","S2","S3"},
                {"S4","S5","S6"},
                {"S7","S8","S9"},
                {"S10","S11","S12"},
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
            }
          
        }
    }
}
