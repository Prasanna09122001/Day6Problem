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
            Console.WriteLine("Enter the number checked to be prime");
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
        public static void perfect()
        {
            Console.WriteLine("Enter the number checked to be perfect");
            int a = Convert.ToInt32(Console.ReadLine()),b=0;
            for(int i=1;i<a;i++)
            {
                if (a % i == 0)
                    b += i;
            }
            if (b == a)
                Console.WriteLine("It is a perfect number");
            else
                Console.WriteLine("It is not a Perfect number");
        }
        public static void Reverse()
        {
            Console.WriteLine("Enter the number to be revesed");
            int a = Convert.ToInt32(Console.ReadLine()),b,c=0;
            while(a!=0)
            {
                b = a % 10;
                c = c*10+b;
                a = a / 10;
            }
            Console.WriteLine(c);

        }
    }
}
