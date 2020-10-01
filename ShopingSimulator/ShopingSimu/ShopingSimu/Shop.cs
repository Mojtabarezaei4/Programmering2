using System;
using System.Collections.Generic;
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
            // Showing the customer the list of products which exist in the shop and also asking for the ordering
            Console.WriteLine("Choose your product/products: ");
            Console.WriteLine();
            Console.WriteLine("1. 1kg Potato" + "\n" +
                                "2. 1kg tomato" + "\n" +
                                "3. 1kg meat" + "\n" +
                                "0. Finish your shoping.");

            // Importing the products class called Products
            Products pro = new Products();

            // Just a variabel for take in the orders
            int _products;

            // A loop for customer can buy as long as it wants
            while (true)
            {
                // Try-catch for if customer don't write any thing so it wouldn't count
                try
                {
                    _products = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You chose wrong option." + "\n" + "Choose one of the given numbers");
                    continue;
                }

                // Here can customer order 
                switch (_products)
                {
                    case 1:
                        pro._productList.Add("1kg potato");
                        continue;
                    case 2:
                        pro._productList.Add("1kg tomato");
                        continue;

                    case 3:
                        pro._productList.Add("1kg meat");
                        continue;

                    default:
                        continue;

                    case 0:
                        break;
                }
                break;
            }

            // Converting a list to an array list
            pro._productList.ToArray();

            Console.WriteLine("You ordered the following products: ");

            // Showing the orders to the customer
            foreach (var ProductList in pro._productList)
            {
                Console.WriteLine(ProductList);
            }
        }
    }
}
