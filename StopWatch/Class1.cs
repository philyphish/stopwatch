﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class Class1
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private string _userInput;
        private TimeSpan _elapsTime;
        

        public string UserInput
        {
            get { return _userInput; }
            set { _userInput = value; }
        }

        public void myTimmer() {
            while (_userInput != "stop")
            {
                _startTime = DateTime.Now;
                Console.WriteLine("running...");
                Console.ReadLine();
                _endTime = DateTime.Now;
                _elapsTime = _endTime - _startTime;
                Console.WriteLine("The elaps time is {0}", _elapsTime + " Press enter to start the timer again and type stop to stop");
                _userInput = Console.ReadLine().ToLower();
            }
    }
}
}
