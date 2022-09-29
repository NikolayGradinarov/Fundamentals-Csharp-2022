using System;

namespace _06.ForeignLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            //Spanish is spoken in Spain, Argentina, and Mexico.           
            //For the others, we should print "unknown".

            string country = Console.ReadLine();

            if (country == "USA" || country == "England")
            {
                Console.WriteLine("English");
            }
            else if (country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
