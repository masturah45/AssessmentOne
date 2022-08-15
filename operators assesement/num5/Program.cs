using System;

namespace num5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your number");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your number");
            int d = int.Parse(Console.ReadLine());

            int add = a + b + c + d;
            Console.WriteLine($"the addition of the number is {add}");

            Console.WriteLine($"{d}{c}{b}{a}");
            Console.WriteLine($"{d}{a}{b}{c}");
            Console.WriteLine($"{a}{c}{b}{d}");
            
            

        }
    }
}
