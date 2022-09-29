using System;

namespace _06.ReversedChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char tree = char.Parse(Console.ReadLine());

            Console.Write($"{tree} {two} {one}");
        }
    }
}
