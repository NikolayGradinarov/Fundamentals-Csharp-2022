using System;

namespace _04.CenturiesТоMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes/365.2422

            int century = int.Parse(Console.ReadLine());

            int years = century * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minute = hours * 60;

            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minute} minutes");
        }
    }
}
