using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Levels
{
    public class Level3 : Handler
    {
        public override void Handle()
        {
            Console.WriteLine("Ваша проблема пов’язана з телефонними викликами? (так/ні)");

            if (Console.ReadLine()?.ToLower() == "так")
            {
                Console.WriteLine("Ваш запит обробляє підтримка 3 рівня");
            }
            else if (_next != null)
            {
                _next.Handle();
            }
        }
    }
}
