using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Subscriptions
{
    public class EducationalSubscription : ISubscription
    {
        public string Name => "Освітня";
        public decimal MonthlyFee => 6.50m;
        public int MinPeriod => 12;
        public List<string> Channels => new List<string> { "Документальні", "Соціальні", "Наукові" };

        public void DisplayInfo() =>
            Console.WriteLine($"Підписка: {Name}\nЩомісячна плата: {MonthlyFee}$\nМінімальний період: {MinPeriod} місяців\nКанали: {string.Join(", ", Channels)}\n");
    }
}
