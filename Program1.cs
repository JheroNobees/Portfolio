using System;

namespace Portfolio
{
    class Program1
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Practice";
            Console.Write("Input your number: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
           
            Console.ReadKey();
        }
    }
}
