using CommerceApp.DAL;
using System;

namespace CommerceApp.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductRepository productRepository = new ProductRepository();
            productRepository.Add(new Data.Product() { Code = "PC", Name = "Juice", Price = 40 });

        }
    }
}
