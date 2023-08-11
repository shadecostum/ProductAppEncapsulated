using ProductAppVersion2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppVersion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Bag", 1000, 50.0);
            Console.WriteLine(product1.TotalPrice());
            Product product2 = new Product(2, "Shirt", 600);
            Console.WriteLine(product2.TotalPrice());
        }
    }
}
