using System;

namespace num6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:(1 < k < N)");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter K: (1 < k < N)");
            int k = int.Parse(Console.ReadLine());

            for (int i = n - 1; i > 0; i--) n *= i;
            for (int i = k - 1; i > 0; i--) k *= i;
            n/= k;
            Console.WriteLine($"Result is {0}", n);
            
                
            
            
                
            
        }
    }
}
