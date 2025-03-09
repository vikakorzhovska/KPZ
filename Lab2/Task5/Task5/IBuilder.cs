using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public interface IBuilder
    {
        IBuilder SetHeight(int height);
        IBuilder SetBuild(string build);
        IBuilder SetHairColor(string hairColor);
        IBuilder SetEyeColor(string eyeColor);
        IBuilder SetOutfit(string outfit);
        IBuilder AddInventoryItem(string item);
        IBuilder AddGoodDeed(string deed);
        IBuilder AddEvilDeed(string deed);
        Product Build();
    }
}
