using System;

namespace _04.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
          
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");    //Make it in "$", because of the space between the numbers 
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
