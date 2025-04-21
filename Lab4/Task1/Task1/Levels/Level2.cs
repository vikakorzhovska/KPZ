using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Levels
{
    public class Level2 : Handler
    {
        public override void Handle()
        {
            Console.WriteLine("Ваша проблема пов’язана з мобільним інтернетом? (так/ні)");

            if (Console.ReadLine()?.ToLower() == "так")
            {
                Console.WriteLine("Ваш запит обробляє підтримка 2 рівня");
            }
            else if (_next != null)
            {
                _next.Handle();
            }
        }
    }
}
