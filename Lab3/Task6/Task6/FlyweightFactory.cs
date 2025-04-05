using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class FlyweightFactory
    {
        private readonly Dictionary<string, LightElementFlyweight> _flyweights = new();

        public LightElementFlyweight GetFlyweight(string tagName, string displayType, bool selfClosing)
        {
            string key = $"{tagName}_{displayType}_{selfClosing}";

            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new LightElementFlyweight(tagName, displayType, selfClosing);
            }

            return _flyweights[key];
        }
    }
}
