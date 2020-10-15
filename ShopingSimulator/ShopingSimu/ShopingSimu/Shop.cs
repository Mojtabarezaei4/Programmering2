using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopingSimu
{
    class Shop
    {
        public void NewCustomer()
        {
            // Imorping the class called Customer 
            Customer newCustomer = new Customer();
            string name = newCustomer._name;

            // Bounch a text from the shop to the customer
            Console.WriteLine("Welcome to your shop.");
            Console.WriteLine("What is your name?");
            Console.WriteLine();

            // Asking customer for it's name
            name = Console.ReadLine();

            // Keep asking just in case the customer didn't write it's name
            while (name == "")
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
            }

            // Calling the method called ProductsOrder to do the shoping progress
            ProductsOrder();
        }


        public void ProductsOrder()
        {

            // Importing the Brand class called Brand which is grandchild of Products
            Brand product = new Brand();

            // A list for store the orders.
            List<String> shopingCart = new List<string>();

            int buyingOptions = 0;

            // A loop for customer can buy as long as it wants
            while (true)
            {
                Console.WriteLine("Do you have any orders?");
                Console.WriteLine("1. To order");
                Console.WriteLine("2. To leave");

                buyingOptions = Convert.ToInt32(Console.ReadLine());
                
                // Asking for orders
                if (buyingOptions == 1) {
                    Console.WriteLine("What do you want?");
                    shopingCart.Add(product._producName = Console.ReadLine());

                    Console.WriteLine("How much of the product?");
                    shopingCart.Add(product._weight = Console.ReadLine());

                    Console.WriteLine("Which Color?");
                    shopingCart.Add(product._color = Console.ReadLine());

                    Console.WriteLine("Which brand?");
                    shopingCart.Add(product._brand = Console.ReadLine());
                }
                else {
                    break;
                }
            }

            Console.WriteLine("You ordered the following products: ");

            // Showing the orders to the customer
            if(shopingCart.Any())
            {
                foreach (var ProductList in shopingCart)
                {
                    Console.WriteLine(ProductList);
                }
            }
            else {
                Console.WriteLine("Nothing!");
            }
        }
    }
}
