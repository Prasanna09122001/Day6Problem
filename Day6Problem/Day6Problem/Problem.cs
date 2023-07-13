using System;

namespace Day6Problem
{
    internal class Problem
    {
        public static void Fib()
        {
            Console.WriteLine("Enter the Number for the Fibonacci Series");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0, c = 1, d;
            Console.Write(b + "," + c);
            for (int i = 2; i < a; ++i)
            {
                d = b + c;
                Console.Write("," + d);
                b = c;
                c = d;
            }
        }
    }
}
