using System;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numBeer = int.Parse(Console.ReadLine());

            double biggestKeg = double.MinValue;   
            
            string modelBeer = "";
            string biggestBeer = "";

            for (int i = 1; i <= numBeer; i++)
            {
                modelBeer = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeKeg = Math.PI * radius * radius * height;

                if (volumeKeg > biggestKeg)
                {
                    biggestKeg = volumeKeg;
                    biggestBeer = modelBeer;
                }
            }
            Console.WriteLine(biggestBeer);
        }
    }
}
