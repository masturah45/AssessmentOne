using System;

namespace num8
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

            if (a < 0 || b < 0 || c < 0)
            {
                Console.WriteLine("-");
                if (a == 0 || b == 0 || c == 0)
                {
                   Console.WriteLine("0"); 
                }
            }

            else
            {
                {
                    Console.WriteLine($"+");
                }
            }
            
            
                
                    
                
            
        }
    }
}
