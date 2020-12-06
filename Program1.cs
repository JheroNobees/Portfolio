using System;

namespace Portfolio
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Title = "Practice";
            Console.WriteLine("ARE YOU READY FOR YOUR PROGRAMMING SKILL!!yes/orno");
            string answer = (Console.ReadLine());
            if (answer == "yes" || answer == "YES")
            {
                Console.WriteLine("That's Good for you to improve your skill");
            }
            else if (answer == "no" || answer == "NO")
            {
                Console.WriteLine("its okeyy maybe next time &_&");
            }else
            {
                Console.WriteLine("Error!!");
            }
            Console.ReadKey();
        }
    }
}
