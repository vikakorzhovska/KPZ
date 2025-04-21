using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Levels
{
    public class Level4 : Handler
    {
        public override void Handle()
        {
            Console.WriteLine("Ваша проблема пов'язана з наявними акціями? (так/ні)");

            if (Console.ReadLine()?.ToLower() == "так")
            {
                Console.WriteLine("Ваш запит обробляє технічна підтримка 4 рівня");
            }
            else
            {
                Console.WriteLine("Вашу проблему не вдалося класифікувати. Повторюємо меню...\n");
                Program.Main(null);
            }
        }
    }
}
