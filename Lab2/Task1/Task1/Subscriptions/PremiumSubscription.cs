using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Subscriptions
{
    public class PremiumSubscription : ISubscription
    {
        public string Name => "Преміум";
        public decimal MonthlyFee => 30.99m;
        public int MinPeriod => 1;
        public List<string> Channels => new List<string> { "Фільми 4K", "Музика", "Фантастика" };

        public void DisplayInfo() =>
            Console.WriteLine($"Підписка: {Name}\nЩомісячна плата: {MonthlyFee}$\nМінімальний період: {MinPeriod} місяців\nКанали: {string.Join(", ", Channels)}\n");
    }
}
