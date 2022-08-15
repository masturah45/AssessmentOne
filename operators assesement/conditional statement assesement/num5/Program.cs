using System;

namespace num5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int score = int.Parse(Console.ReadLine());
            if (score <= 3 && score >= 1)
            {
                int a = score * 10;
                Console.WriteLine(a);
            }

            else if (score <= 6 && score >= 4)
            {
                int b = score * 100;
                Console.WriteLine(b);
            }

            else if (score <= 9 && score >= 7)
            {
               int c = score * 1000;
               Console.WriteLine(c);
            }

            else if (score <= 0 || score >= 9)
            {
                Console.WriteLine("the score is below exectations");
            }

            else
            {
                Console.WriteLine("score");
            }
        }
    }
}
