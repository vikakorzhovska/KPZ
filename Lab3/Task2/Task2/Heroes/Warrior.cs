using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Heroes
{
    public class Warrior : IHero
    {
        public void Attack()
        {
            Console.WriteLine("Warrior атакує");
        }
    }
}
