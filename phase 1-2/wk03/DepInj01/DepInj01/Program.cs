using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInj01
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate new filelogger and databaselogger
            ILogger logger = new FileLogger();
            ILogger logger2 = new DatabaseLogger();
            
            //pass new filelogger-type logger variable into 
            //instantiation of ProductService class
            ProductService productService = new ProductService(logger);

            //database version of productService
            ProductService productServiceD = new ProductService(logger2);

            //log to text file
            productService.Log("Chante testing final result");

            //log to db
            productServiceD.Log("load my database");
        }
    }
}
