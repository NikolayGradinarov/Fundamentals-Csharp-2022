using System;
using System.Numerics;

namespace WorkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numberOfPeople / capacity);

            if (numberOfPeople % capacity != 0)
            {
                Console.WriteLine(courses);
            }
            else
            {
                Console.WriteLine(courses);
            }

        }
    }
}