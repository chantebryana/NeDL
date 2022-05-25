using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInj01
{
    public class ProductService
    {
        //implement interface instead
        //still not as flexible as a full-blown dependency injection
        ILogger _logger = new FileLogger();
        ILogger _logger2 = new DatabaseLogger();

        public void LogF(string message)
        {
            _logger.Log(message);
        }

        public void LogD(string message)
        {
            _logger2.Log(message);
        }
    }
}
