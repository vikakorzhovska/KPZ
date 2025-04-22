using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Strategy;

namespace Task5.Core
{
    public class LightImageNode : LightNode
    {
        public string Source { get; set; }
        private IImageLoadStrategy _strategy;

        public LightImageNode(string source, IImageLoadStrategy strategy)
        {
            Source = source;
            _strategy = strategy;
        }

        public void SetStrategy(IImageLoadStrategy strategy)
        {
            _strategy = strategy;
        }

        public override string OuterHTML()
        {
            return $"<img src=\"{Source}\" alt=\"{_strategy.Load(Source)}\" />";
        }

        public override string InnerHTML() => string.Empty;
    }

}
