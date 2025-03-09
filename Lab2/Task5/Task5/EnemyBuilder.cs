using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class EnemyBuilder : IBuilder
    {
        private Product _product = new Product();

        public IBuilder SetHeight(int height)
        {
            _product.Height = height;
            return this;
        }

        public IBuilder SetBuild(string build)
        {
            _product.Build = build;
            return this;
        }

        public IBuilder SetHairColor(string hairColor)
        {
            _product.HairColor = hairColor;
            return this;
        }

        public IBuilder SetEyeColor(string eyeColor)
        {
            _product.EyeColor = eyeColor;
            return this;
        }

        public IBuilder SetOutfit(string outfit)
        {
            _product.Outfit = outfit;
            return this;
        }

        public IBuilder AddInventoryItem(string item)
        {
            _product.Inventory.Add(item);
            return this;
        }

        public IBuilder AddGoodDeed(string deed)
        {
            return this;
        }

        public IBuilder AddEvilDeed(string deed)
        {
            _product.EvilDeeds.Add(deed);
            return this;
        }

        public Product Build()
        {
            return _product;
        }
    }
}
