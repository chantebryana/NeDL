using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInj01
{
    internal class ProductService
    {
        //ProductService doesn't inherit on FileLogger, 
        //but does instantiate a local FileLogger element
        //PS is therefore dependent of FL

        //it's inflexible / too tightly coupled to structure the code this way. 

        //instantiate instance of FileLogger
        private readonly FileLogger _fileLogger = new FileLogger();

        //instantiate instance of DatabaseLogger
        private readonly DatabaseLogger _databaseLogger = new DatabaseLogger();

        //Log method; calls Log method inside FileLogger class
        public void LogToFile(string message)
        {
            _fileLogger.Log(message);
        }

        //Log method; calls Log method inside DatabaseLogger class
        public void LogToDatabase(string message)
        {
            _databaseLogger.Log(message);
        }

    }
}
