using System;

namespace num4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("it is a prime number");
                }
                
            }

            
            


            if (n == 2)
            {
                Console.WriteLine("it is a prime number");
            }

            else
            {
                Console.WriteLine("it is not a prime number");
            }
        }
    }
}
