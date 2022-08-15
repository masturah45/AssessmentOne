using System;

namespace num7
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

            
            Console.WriteLine("enter your number");
            int e = int.Parse(Console.ReadLine());


            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine(a);
            }

            else if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine(b);
            }

           else if (c > a && c > b && c > d && c > e)
            {
                Console.WriteLine(c);
            }

           else if (d > a && d > b && d > c && d > e)
            {
                Console.WriteLine(d);
            }

           else if (e > a && e > b && e > c && e > d)
            {
                Console.WriteLine(e);
            }

            else
            {
                Console.WriteLine("they are equal");
            }

            




        }
    }
}
