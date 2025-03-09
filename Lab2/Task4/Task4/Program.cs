using System.Text;
using Task4;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Virus virus1 = new Virus("Virus A", 17, 5, "Type 1");
Virus virus2 = new Virus("Virus B", 13, 7, "Type 2");
Virus virus3 = new Virus("Virus C", 9, 3, "Type 3");

virus1.AddChild(new Virus("Virus A1", 6, 1, "Type 1"));
virus2.AddChild(new Virus("Virus B1", 9, 2, "Type 2"));
virus2.AddChild(new Virus("Virus B2", 4, 2, "Type 2"));
virus3.AddChild(new Virus("Virus C1", 2, 1, "Type 3"));

Virus clonedVirus = (Virus)virus1.Clone();

Console.WriteLine("Оригінальний вірус 1:");
virus1.DisplayInfo();

Console.WriteLine("\nСклонований Вірус:");
clonedVirus.DisplayInfo();
