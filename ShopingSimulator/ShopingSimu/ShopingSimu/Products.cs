using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingSimu
{
    class Products
    {
        public List<String> _productList = new List<string>();
        public int _products;

        public void ProductsOrder()
        {
            Console.WriteLine("Choose your product/products: ");
            Console.WriteLine();
            Console.WriteLine("1. 1kg Potato" + "\n" +
                                "2. 1kg tomato" + "\n" +
                                "3. 1kg meat" + "\n" +
                                "0. Finish your shoping.");

            while (true)
            {
                try
                {
                    _products = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You chose wrong option." + "\n" + "Choose one of the given numbers");
                    continue;
                }

                switch (_products)
                {
                    case 1:
                        _productList.Add("1kg potato");
                        continue;
                    case 2:
                        _productList.Add("1kg tomato");
                        continue;

                    case 3:
                        _productList.Add("1kg meat");
                        continue;

                    default:
                        continue;

                    case 0:
                        break;
                }
                break;
            }

            _productList.ToArray();

            Console.WriteLine("You ordered the following products: ");

            foreach (var ProductList in _productList)
            {
                Console.WriteLine(ProductList);
            }
        }
    }
}
