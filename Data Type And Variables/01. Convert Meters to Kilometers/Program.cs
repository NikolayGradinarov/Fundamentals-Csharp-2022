using System;

namespace Data_Types_and_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());

            double sum = (int)distance * 0.001;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
