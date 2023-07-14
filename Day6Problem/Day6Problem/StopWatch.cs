using System;

namespace Day6Problem
{
    class StopWatch
    {
        const string START = "start", STOP = "stop";
        public static void Watch()
        {
            DateTime timeSpan1 = DateTime.Now;
            Console.WriteLine("Enter start to run the stop watch");
            string input = Console.ReadLine();
            if(input.ToLower().Equals(START))
            {
                int hour1 = timeSpan1.Hour;
                int min1 = timeSpan1.Minute;
                int sec1 = timeSpan1.Second;
                int milliSec1 = timeSpan1.Millisecond;
                Console.WriteLine("Enter Sto to end the stopwatch");
                DateTime timeSpan = DateTime.Now;
                string endInput = Console.ReadLine();
                if(endInput.ToLower().Equals(STOP))
                {
                    int hour2 = timeSpan.Hour;
                    int min2 = timeSpan.Minute;
                    int sec2 = timeSpan.Second;
                    int milliSec2 = timeSpan.Millisecond;
                    Console.WriteLine((hour2-hour1) + ":" + (min2-min1) + ":" + (sec2-sec1) + ":" +(milliSec2-milliSec1));
                }
            }


        }
    }
}