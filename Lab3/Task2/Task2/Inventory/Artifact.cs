using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Inventory
{
    internal class Artifact : HeroDecorator
    {
        public Artifact(IHero hero) : base(hero) { }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine(" + Артефакт посилює атаку!");
        }
    }
}
