using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Mementos;

namespace Task5.Core
{
    public class TextEditor
    {
        private readonly TextDocument _document;
        private readonly HistoryManager _history;

        public TextEditor()
        {
            _document = new TextDocument();
            _history = new HistoryManager(this);
        }

        public void Write(string text)
        {
            _document.Replace(text);
        }

        public void Save()
        {
            _history.Backup();
        }

        public void Undo()
        {
            _history.Undo();
        }

        public string GetText()
        {
            return _document.Content;
        }

        public ITextMemento SaveState()
        {
            return new TextMemento(_document.Content);
        }

        public void RestoreState(ITextMemento memento)
        {
            _document.Replace(memento.GetText());
        }
    }
}
