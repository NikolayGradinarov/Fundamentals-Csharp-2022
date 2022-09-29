using System;

namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int ascii = firstNumber; ascii <= secondNumber; ascii++)
            {
                Console.Write((char)ascii + " ");
            }
        }
    }
}
