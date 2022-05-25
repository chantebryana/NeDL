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

        //instantiate instance of FileLogger
        private readonly FileLogger _fileLogger = new FileLogger();

        //Log method; calls Log method inside FileLogger class
        public void Log(string message)
        {
            _fileLogger.Log(message);
        }
    }
}
