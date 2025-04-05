using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class LightElementNode : LightNode
    {
        private readonly LightElementFlyweight _flyweight;
        public List<LightNode> Children { get; } = new List<LightNode>();

        public LightElementNode(LightElementFlyweight flyweight)
        {
            _flyweight = flyweight;
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public override string OuterHTML()
        {
            string outerHtml = $"<{_flyweight.TagName}>";

            if (!_flyweight.SelfClosing)
            {
                outerHtml += InnerHTML();
                outerHtml += $"</{_flyweight.TagName}>";
            }

            return outerHtml;
        }

        public override string InnerHTML()
        {
            return string.Concat(Children.Select(child => child.OuterHTML()));
        }
    }
}
