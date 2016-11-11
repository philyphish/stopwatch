using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
   public class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("Enter start: ");
            userInput = Console.ReadLine();


            var sw = new Class1();
            sw.userInput = userInput;

            sw.myTimmer();
            



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
