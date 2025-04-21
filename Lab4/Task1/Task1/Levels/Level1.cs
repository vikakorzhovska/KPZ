using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Levels
{
    public class Level1 : Handler
    {
        public override void Handle()
        {
            Console.WriteLine("Ви зателефонували до служби підтримки");
            Console.WriteLine("Ваша проблема пов’язана з балансом рахунку? (так/ні)");

            if (Console.ReadLine()?.ToLower() == "так")
            {
                Console.WriteLine("Ваш запит обробляє підтримка 1 рівня");
            }
            else if (_next != null)
            {
                _next.Handle();
            }
        }
    }
}
