using System;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int pouredLiters = int.Parse(Console.ReadLine());
                sum += pouredLiters;

                if (sum > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= pouredLiters;
                }               
            }
            Console.WriteLine(sum);
        }
    }
}
