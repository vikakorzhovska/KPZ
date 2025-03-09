using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class CharacterDirector
    {
        private IBuilder _builder;

        public CharacterDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public Product BuildHero()
        {
            return _builder.SetHeight(170)
                           .SetBuild("М'язистий")
                           .SetHairColor("Темне")
                           .SetEyeColor("Карі")
                           .SetOutfit("Броня")
                           .AddInventoryItem("Меч")
                           .AddInventoryItem("Кинжал")
                           .AddGoodDeed("Врятував дитину")
                           .Build();
        }

        public Product BuildEnemy()
        {
            return _builder.SetHeight(190)
                           .SetBuild("Кремезний")
                           .SetHairColor("Темне")
                           .SetEyeColor("Чорні")
                           .SetOutfit("Мантія")
                           .AddInventoryItem("Спис")
                           .AddEvilDeed("Вбив 10 людей")
                           .Build();
        }
    }
}
