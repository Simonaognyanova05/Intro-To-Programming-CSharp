using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            string usingPass;
            int attempt = 5;

            while(attempt != 0)
            {
                Console.Write("Use your password to login: ");
                usingPass = Console.ReadLine();
                if(usingPass != password)
                {
                    attempt -= 1;
                    Console.WriteLine($"You have {attempt} more attempts");
                }
                else
                {
                    Console.WriteLine($"Welcome, {username}!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
