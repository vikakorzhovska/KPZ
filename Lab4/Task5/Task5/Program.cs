using Task5.Core;

var editor = new TextEditor();

editor.Write("Hello");
editor.Save();

editor.Write("Hello, world!");
editor.Save();

editor.Write("Unsaved changes!");

Console.WriteLine("Current text: " + editor.GetText());
editor.Undo();
Console.WriteLine("After undo: " + editor.GetText());
editor.Undo();
Console.WriteLine("After second undo: " + editor.GetText());