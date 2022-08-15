using System;

namespace num10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int num = int.Parse(Console.ReadLine());
            double pounds = num * 0.454;
            Console.WriteLine(pounds);
        }
    }
}
