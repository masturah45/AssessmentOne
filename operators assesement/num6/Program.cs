using System;

namespace num6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int a = int.Parse(Console.ReadLine());
            int b = a/100;
            int c = b%10;
            if (c == 7)
            {
                Console.WriteLine("seven exist from the left");
            }

            else
            {
                Console.WriteLine("seven does not exist from the left");
            }
        }
    }
}
