using System;

namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dollar = double.Parse(Console.ReadLine());

            double sum = dollar * 1.31;
            Console.WriteLine($"{sum:f3}");
        }
    }
}
