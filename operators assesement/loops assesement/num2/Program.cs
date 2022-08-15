using System;

namespace num2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number you want your triangle to repeat");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
            }
        }
    }
}
