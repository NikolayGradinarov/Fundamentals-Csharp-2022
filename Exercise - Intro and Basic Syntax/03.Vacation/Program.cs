using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double totalPrice = 0.0;
            double pricePerPerson = 0.0;

            //Students

            if (dayOfWeek == "Friday" && typeGroup == "Students")
            {
                pricePerPerson += 8.45;
            }
            else if (dayOfWeek == "Saturday" && typeGroup == "Students")
            {
                pricePerPerson += 9.80;
            }
            else if (dayOfWeek == "Sunday" && typeGroup == "Students")
            {
                pricePerPerson += 10.46;
            }

            //Business

            if (dayOfWeek == "Friday" && typeGroup == "Business")
            {
                pricePerPerson += 10.90;
            }
            else if (dayOfWeek == "Saturday" && typeGroup == "Business")
            {
                pricePerPerson += 15.60;
            }
            else if (dayOfWeek == "Sunday" && typeGroup == "Business")
            {
                pricePerPerson += 16;
            }

            //Regular

            if (dayOfWeek == "Friday" && typeGroup == "Regular")
            {
                pricePerPerson += 15;
            }
            else if (dayOfWeek == "Saturday" && typeGroup == "Regular")
            {
                pricePerPerson += 20;
            }
            else if (dayOfWeek == "Sunday" && typeGroup == "Regular")
            {
                pricePerPerson += 22.50;
            }

            totalPrice = people * pricePerPerson;

            //discounts

            if (typeGroup == "Students" && people >= 30)
            {
                totalPrice = totalPrice * 0.85;                                       //15% from 100 is (* 0.85)
            }                                                                         //Same goes for 5% from 100 is (* 0.95)
            else if (typeGroup == "Business" && people >= 100)
            {
                totalPrice = totalPrice - (pricePerPerson * 10);
            }
            else if (typeGroup == "Regular" && people >= 10 && people <= 20)
            {
                totalPrice = totalPrice * 0.95;
            }
           
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
