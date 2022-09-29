using System;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double coins = 0.0;

            while (true)
            {
                string coinsCommand = Console.ReadLine();

                if (coinsCommand == "Start")
                {
                    break;
                }

                double cents = double.Parse(coinsCommand);

                if (cents == 0.1)
                {
                    coins += cents;
                }
                else if (cents == 0.2)
                {
                    coins += cents;
                }
                else if (cents == 0.5)
                {
                    coins += cents;
                }
                else if (cents == 1)
                {
                    coins += cents;
                }
                else if (cents == 2)
                {
                    coins += cents;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {cents}");
                }
            }

            while (true)
            {
                string products = Console.ReadLine();

                if (products == "End")
                {
                    break;
                }

                if (products == "Nuts")
                {
                    coins -= 2.0;

                    if (coins >= 0)
                    {
                        Console.WriteLine($"Purchased nuts");
                    }
                    else
                    {
                        coins += 2.0;
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (products == "Water")
                {
                    coins -= 0.7;

                    if (coins >= 0)
                    {
                        Console.WriteLine($"Purchased water");
                    }
                    else
                    {
                        coins += 0.7;
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (products == "Crisps")
                {
                    coins -= 1.5;

                    if (coins >= 0)
                    {
                        Console.WriteLine($"Purchased crisps");
                    }
                    else
                    {
                        coins += 1.5;
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (products == "Soda")
                {
                    coins -= 0.8;

                    if (coins >= 0)
                    {
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        coins += 0.8;
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (products == "Coke")
                {
                    coins -= 1.0;

                    if (coins >= 0)
                    {
                        Console.WriteLine($"Purchased coke");
                    }
                    else
                    {
                        coins += 1.0;
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }

            Console.WriteLine($"Change: {coins:F2}");
        }
    }
}
