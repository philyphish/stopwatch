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
            var timmer = new Class1();
            DateTime startTime;
            DateTime stopTime;

            Console.WriteLine("Enter start: ");
            userInput = Console.ReadLine();
            startTime = timmer.Start = DateTime.Now;

            while (userInput != "stop")
            {
                Console.WriteLine("Stop watch started...");
                userInput = Console.ReadLine();
                if (userInput != "stop")
                {
                    Console.WriteLine("Invalid response. Type stop to stop the Stop Watch. ");
                }
                
            } 
            stopTime = timmer.Stop = DateTime.Now;
            TimeSpan elapsTime = stopTime - startTime;

            Console.WriteLine(elapsTime);


            //Console.WriteLine("The elaps time is Press enter to start the timer again and type stop to stop");
            //userInput = Console.ReadLine();
            //Class1.MyTimmer(userInput);
        }
       
    }
}
