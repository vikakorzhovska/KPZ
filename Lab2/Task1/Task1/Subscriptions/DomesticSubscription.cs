using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Subscriptions
{
    public class DomesticSubscription : ISubscription
    {
        public string Name => "Домашня";
        public decimal MonthlyFee => 15.50m;
        public int MinPeriod => 6;
        public List<string> Channels => new List<string> { "Новини", "Фільми", "Музика" };

        public void DisplayInfo() =>
            Console.WriteLine($"Підписка: {Name}\nЩомісячна плата: {MonthlyFee}$\nМінімальний період: {MinPeriod} місяців\nКанали: {string.Join(", ", Channels)}\n");
    }
}
