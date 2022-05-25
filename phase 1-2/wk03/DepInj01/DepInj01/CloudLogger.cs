using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInj01
{
    internal class CloudLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of CloudLogger.");
            LogToCloud(message);
        }

        //private method; use in DatabaseLogger
        private void LogToCloud(string message)
        {
            Console.WriteLine("Method: LogToCloud, Text {0}", message);
        }
    }
}
