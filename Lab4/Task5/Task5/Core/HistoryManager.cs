using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Mementos;

namespace Task5.Core
{
    public class HistoryManager
    {
        private readonly List<ITextMemento> _snapshots = new();
        private readonly TextEditor _editor;

        public HistoryManager(TextEditor editor)
        {
            _editor = editor;
        }

        public void Backup()
        {
            _snapshots.Add(_editor.SaveState());
        }

        public void Undo()
        {
            if (_snapshots.Count == 0) return;

            var lastSnapshot = _snapshots[^1];
            _snapshots.RemoveAt(_snapshots.Count - 1);
            _editor.RestoreState(lastSnapshot);
        }
    }
}
