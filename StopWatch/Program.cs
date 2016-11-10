using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime;
            DateTime endTime;
            string userInput;
            TimeSpan elapsTime;

            Console.WriteLine("Enter start: ");
            userInput = Console.ReadLine();

            while (userInput != "stop")
            {
                startTime = DateTime.Now;
                Console.ReadLine();
                endTime = DateTime.Now;
                elapsTime = endTime - startTime;
                Console.WriteLine("The elaps time is {0}" , elapsTime + " Press enter to start the timer again and type stop to stop");
                userInput = Console.ReadLine().ToLower();

            }



        }
        //static void ShowTimeSpanProperties(TimeSpan interval)
        //{
        //    Console.WriteLine("{0,21}", interval);
        //    Console.WriteLine("{0,-12}{1,8}       {2,-18}{3,21:N3}", "Days",
        //                      interval.Days, "TotalDays", interval.TotalDays);
        //    Console.WriteLine("{0,-12}{1,8}       {2,-18}{3,21:N3}", "Hours",
        //                      interval.Hours, "TotalHours", interval.TotalHours);
        //    Console.WriteLine("{0,-12}{1,8}       {2,-18}{3,21:N3}", "Minutes",
        //                      interval.Minutes, "TotalMinutes", interval.TotalMinutes);
        //    Console.WriteLine("{0,-12}{1,8}       {2,-18}{3,21:N3}", "Seconds",
        //                      interval.Seconds, "TotalSeconds", interval.TotalSeconds);
        //    Console.WriteLine("{0,-12}{1,8}       {2,-18}{3,21:N3}", "Milliseconds",
        //                      interval.Milliseconds, "TotalMilliseconds",
        //                      interval.TotalMilliseconds);
        //    Console.WriteLine("{0,-12}{1,8}       {2,-18}{3,21:N0}", null, null,
        //        "Ticks", interval.Ticks);
        //}
    }
}
