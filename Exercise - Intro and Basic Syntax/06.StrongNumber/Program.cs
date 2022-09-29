using System;

namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Modular division by 10 = return last digit
            //Integer division by 10 = removes last digit

            int numcopy = n;
            int factorialSum = 0;

            while (numcopy > 0)
            {
                int lastDigit = numcopy % 10;  // Take last digit
                numcopy /= 10;   // Remove last digit

                //Calculate factorial of last digit

                int factorial = 1;

                for (int i = 2; i <= lastDigit; i++)
                {
                    factorial *= i;
                }

                //Summing factorial
                factorialSum += factorial;               
            }

            if (factorialSum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
