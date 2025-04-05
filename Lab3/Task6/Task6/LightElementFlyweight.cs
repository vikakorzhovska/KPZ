using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class LightElementFlyweight
    {
        public string TagName { get; }
        public string DisplayType { get; }
        public bool SelfClosing { get; }

        public LightElementFlyweight(string tagName, string displayType, bool selfClosing)
        {
            TagName = tagName;
            DisplayType = displayType;
            SelfClosing = selfClosing;
        }
    }
}
