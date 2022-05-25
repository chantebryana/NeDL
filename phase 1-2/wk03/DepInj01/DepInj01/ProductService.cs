using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInj01
{
    public class ProductService
    {
        //proper dependency injection, finally

        //declare private logger property
        private readonly ILogger _logger;

        //constructor
        public ProductService(ILogger logger)
        {
            _logger = logger;
        }

        //log method
        public void Log(string message)
        {
            _logger.Log(message);
        }
    }
}
