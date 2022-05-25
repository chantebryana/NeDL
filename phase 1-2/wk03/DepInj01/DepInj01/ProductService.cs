using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInj01
{
    internal class ProductService
    {
        private readonly FileLogger _fileLogger = new FileLogger();
        public void Log(string message)
        {
            _fileLogger.Log(message);
        }
    }
}
