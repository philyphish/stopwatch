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
            sw.UserInput = userInput;
            sw.myTimmer();
          
        }
        
    }
}
 