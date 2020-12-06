using System;

namespace Portfolio
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Title = "Practice";

            Console.WriteLine("What is your name?");
            string user = Console.ReadLine();
            Console.Write("Hello, " +user+ " Nice to meet you");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.ReadKey();
        }
    }
}
