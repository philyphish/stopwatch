using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class Class1
    {
        DateTime startTime;
        DateTime endTime;
        public string userInput;
        TimeSpan elapsTime;

            
        public void myTimmer() {
            while (userInput != "stop")
            {
                startTime = DateTime.Now;
                Console.WriteLine("running...");
                Console.ReadLine();
                endTime = DateTime.Now;
                elapsTime = endTime - startTime;
                Console.WriteLine("The elaps time is {0}", elapsTime + " Press enter to start the timer again and type stop to stop");
                userInput = Console.ReadLine().ToLower();
            }
    }
}
}
