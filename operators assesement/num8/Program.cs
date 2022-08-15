using System;

namespace num8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int number = int.Parse(Console.ReadLine());
            double num1 = number * 0.17;
            Console.WriteLine(num1);

        }
    }
}
