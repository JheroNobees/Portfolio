using System;

namespace Portfolio
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Title = "Practice";
            //Print this 
            double num1;
            double num2;
            double num3;

            Console.Write("Input your number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input your second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input your third Number: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            double result = (num1 + num2 + num3)/3;
            Console.WriteLine("Your average is " + result);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.ReadKey();
        }
    }
}
