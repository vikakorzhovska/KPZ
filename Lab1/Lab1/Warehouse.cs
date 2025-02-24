using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Warehouse
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(string productName, int quantity)
        {
            var product = products.Find(p => p.Name == productName);
            if (product != null && product.Quantity >= quantity)
            {
                product = new Product(product.Name, product.Unit, product.Price, product.Quantity - quantity, product.LastDeliveryDate);
            }
        }

        public void ListProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
