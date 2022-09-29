using System;
using System.Numerics;

namespace WorkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2147483647


            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger fourthNumber = BigInteger.Parse(Console.ReadLine());

            BigInteger sum = 0;

            sum = firstNumber + secondNumber;
            sum /= thirdNumber;
            sum *= fourthNumber;

            Console.WriteLine(sum);
        }
    }
}