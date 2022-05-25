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
            ProductService productService = new ProductService();
            productService.Log("Chante's testing the method all by myself.");
        }
    }
}
