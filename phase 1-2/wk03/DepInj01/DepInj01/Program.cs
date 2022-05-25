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
            //instantiate ProductService
            ProductService productService = new ProductService();

            //log to file
            productService.LogToFile("Chante's testing the method all by myself.");

            //log to database
            productService.LogToDatabase("Chante's testing the database.");
        }
    }
}
