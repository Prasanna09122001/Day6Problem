using System;
using System.Data;

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
        public static void prime()
        {
            int a = Convert.ToInt32(Console.ReadLine()),b=0;
            for (int i = 1; i < a; i++)
            {
                if(a%i==0)
                b++;
            }
            if (b<2)
            {
                Console.WriteLine("It is a Prime Number");
            }
            else
            {
                Console.WriteLine("It is Not a Prime Number");
            }
        }
    }
}
