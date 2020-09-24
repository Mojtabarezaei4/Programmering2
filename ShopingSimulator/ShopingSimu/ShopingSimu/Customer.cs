using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingSimu
{
    class Customer
    {
        public String _name;

        Products product = new Products();

        public void NewCustomer()
        {
            Console.WriteLine("Welcome to your shop.");
            Console.WriteLine("What is your name?");
            Console.WriteLine();

            _name = Console.ReadLine();

            while (_name == "")
            {
                Console.WriteLine("What is your name?");
                _name = Console.ReadLine();
            }

            product.ProductsOrder();
        }
    }
}
