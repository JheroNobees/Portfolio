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
            Console.WriteLine("Hello, " +user+ " Nice to meet you");
            Console.ReadLine();
            Console.WriteLine("How's your day?");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("That's Good ^_^");
            Console.ReadKey();
        }
    }
}
