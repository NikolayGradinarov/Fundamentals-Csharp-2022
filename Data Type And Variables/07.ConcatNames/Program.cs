using System;

namespace _07.ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOne = Console.ReadLine();
            string nameTwo = Console.ReadLine();
            var delimeter = Console.ReadLine();

            Console.WriteLine($"{nameOne}{delimeter}{nameTwo}");
        }
    }
}
