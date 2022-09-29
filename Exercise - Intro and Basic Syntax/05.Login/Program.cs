using System;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;                 

            for (int i = username.Length - 1; i >= 0; i--)  // <---
            {
                char currentChar = username[i];                          //reverse password
                password += currentChar;               
            }

            int loginCount = 0;

            while (true)
            {
                string pass = Console.ReadLine();

                if (pass == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                loginCount++;

                if (loginCount >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                if (pass != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");                   
                }               
            }
        }
    }
}
