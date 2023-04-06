using System;
using System.Collections.Generic;

namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> product = new Dictionary<string, double>();
            Dictionary<string, int> prouctQty = new Dictionary<string, int>();

            string commomand;
            while ((commomand = Console.ReadLine()) != "buy")
            {
                string[] cmArgs = commomand.Split(' ');

                string nameProduct = cmArgs[0];
                double priceProduct = double.Parse(cmArgs[1]);
                int qtyProduct = int.Parse(cmArgs[2]);

                if (!product.ContainsKey(nameProduct))
                {
                    product[nameProduct] = 0;
                }
                SwitchPrice(product, nameProduct, priceProduct);
                product[nameProduct] = priceProduct;
                Quantity(prouctQty, nameProduct, qtyProduct);
            }

            foreach (var kvp in product)
            {
                double price = kvp.Value * prouctQty[kvp.Key];

                Console.WriteLine($"{kvp.Key} -> {price:F2}");
            }
        }

        static double SwitchPrice(Dictionary<string, double> product, string nameProduct, double price)
        {
            if (product.ContainsKey(nameProduct) && !product.ContainsValue(price))
            {
                return price;
            }
            return price;
        }

        static void Quantity(Dictionary<string, int> prouctQty, string nameProduct,
            int qtyProduct)
        {
            if (!prouctQty.ContainsKey(nameProduct))
            {
                prouctQty[nameProduct] = qtyProduct;
            }
            else
            {
                prouctQty[nameProduct] += qtyProduct;

            }
        }

    }
}
