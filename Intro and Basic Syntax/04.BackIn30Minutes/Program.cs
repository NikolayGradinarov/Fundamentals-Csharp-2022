using System;

namespace _04.BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The first number is hours and will be between 0 and 23.
            //The second number is minutes and will be between 0 and 59.

            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            minute += 30;

            if (minute > 60)
            {
                hour += 1;
                minute -= 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }

            Console.WriteLine($"{hour}:{minute:d2}");
        }
    }
}
