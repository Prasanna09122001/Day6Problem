using System;

namespace Day6Problem
{
    class Money
    {
        
        public static void money()
        {
            Console.WriteLine("enter the Amount to be Returned");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 1000;
            a -= (b * 1000);
            Console.WriteLine("The number of 1000 Rupees notes = "+b);
            int c = a / 500;
            a -= (c * 500);
            Console.WriteLine("The number of 500 Rupees notes = "+c);
            int d = a / 100;
            a -= (d * 100);
            Console.WriteLine("The number of 100 Rupees notes = "+d);
            int e = a / 50;
            a -= (e * 50);
            Console.WriteLine("The number of 50 Rupees notes = "+e);
            int f = a / 20;
            a -= (f * 20);
            Console.WriteLine("The number of 20 Rupees notes = "+f);
            int g = a / 10;
            a -= (g * 10);
            Console.WriteLine("The number of 10 Rupees notes = "+g);
            int h = a / 5;
            a -= (h * 5);
            Console.WriteLine("The number of 5 Rupees coin = "+h);
            int i = a / 2;
            a -= (i * 2);
            Console.WriteLine("The number of 2 Rupees coin = "+i);
            Console.WriteLine("The number of 1 Rupee coin = "+a);
            Console.WriteLine("The Total Number of the Notes is " + (a + b + c + d + e + f + g + h + i));
        }
        public static void DateDay()
        {
            Console.Write("Enter the Date");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Day");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Year");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime day= new DateTime(year,month,date);
            Console.WriteLine(day.DayOfWeek);
        }
    }
}
