using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Mementos
{
    public class TextMemento : ITextMemento
    {
        private readonly string _text;

        public TextMemento(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            return _text;
        }
    }
}
