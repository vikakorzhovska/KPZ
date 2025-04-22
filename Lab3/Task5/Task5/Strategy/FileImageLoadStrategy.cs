using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Strategy
{
    public class FileImageLoadStrategy : IImageLoadStrategy
    {
        public string Load(string source)
        {
            return $"[Loaded image from file: {source}]";
        }
    }
}
