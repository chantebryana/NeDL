using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInj01
{
    internal class FileLogger
    {
        //no variables or properties to implement
        //no constructors
        //go straight to building methods
        
        //method 1
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of FileLogger");
            LogToFile(message);
        }
        
        //method 2
        private void LogToFile(string message)
        {
            Console.WriteLine("Method: LogToFile, Text: {0}", message);
        }
    }
}
