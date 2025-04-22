using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Core
{
    public class TextDocument
    {
        public string Content { get; set; }

        public TextDocument()
        {
            Content = string.Empty;
        }

        public void Append(string text)
        {
            Content += text;
        }

        public void Replace(string text)
        {
            Content = text;
        }
    }
}
