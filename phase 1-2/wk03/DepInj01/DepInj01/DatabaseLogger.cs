using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInj01
{
    //internal class DatabaseLogger
    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of DatabaseLogger.");
            LogToDatabase(message);
        }

        //private method; use in DatabaseLogger
        private void LogToDatabase(string message)
        {
            Console.WriteLine("Method: LogToDatabase, Text {0}", message);
        }
    }
}
