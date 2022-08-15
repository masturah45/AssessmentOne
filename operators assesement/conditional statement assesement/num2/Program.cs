using System;

namespace num2
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
                int number = int.Parse(Console.ReadLine());

                switch(number)

                {
                    case 1:
                Console.WriteLine(a + b);
                break;

                case 2:
                Console.WriteLine(a - b);
                break;

                case 3:
                Console.WriteLine(a * b);
                break;

                case 4:
                Console.WriteLine(a / b);
                break;

                case 5:
                Console.WriteLine("exit");
                break;

                default:
                Console.WriteLine("invalid input");
                break;

                Console.WriteLine("perform another operation? if yes press 1, if no press 2");
                }
                

                

        }
    }
}
