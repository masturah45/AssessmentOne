using System;

namespace num5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int num = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 1; i <= num; i++)
            {
                total = i * i;
                Console.WriteLine(total);
            }
        }
    }
}
