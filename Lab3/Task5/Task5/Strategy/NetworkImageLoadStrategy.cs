using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Strategy
{
    public class NetworkImageLoadStrategy : IImageLoadStrategy
    {
        public string Load(string source)
        {
            return $"[Loaded image from URL: {source}]";
        }
    }
}
