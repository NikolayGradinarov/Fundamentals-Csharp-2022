using System;

namespace _09.CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char tree = char.Parse(Console.ReadLine());

            Console.WriteLine($"{one}{two}{tree}");
        }
    }
}
