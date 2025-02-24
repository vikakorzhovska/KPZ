using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Reporting
    {
        public void InventoryReport(Warehouse warehouse)
        {
            Console.WriteLine("Інвентаризація складу:");
            warehouse.ListProducts();
        }

        public void RegisterOfGoodsReceipt(Warehouse warehouse, string productName, int quantity, DateTime deliveryDate)
        {
            var product = warehouse.FindProduct(productName);
            if (product != null)
            {
                product.IncreaseQuantity(quantity, deliveryDate);
                Console.WriteLine($"Надходження: {quantity} {product.Unit} {productName} додано на склад");
            }
        }

        public void RegisterOfShipmentOfGoods(Warehouse warehouse, string productName, int quantity)
        {
            var product = warehouse.FindProduct(productName);
            if (product != null && product.Quantity >= quantity)
            {
                product.DecreaseQuantity(quantity);
                Console.WriteLine($"Відвантаження: {quantity} {product.Unit} {productName} відправлено зі складу");
            }
            else
            {
                Console.WriteLine($"Помилка: недостатньо {productName} на складі!");
            }
        }
    }
}
