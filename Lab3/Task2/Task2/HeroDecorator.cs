using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class HeroDecorator : IHero
    {
        protected IHero _hero;

        public HeroDecorator(IHero hero)
        {
            _hero = hero;
        }

        public virtual void Attack()
        {
            _hero.Attack();
        }
    }
}
