using System.Text;
using Task1.Levels;
public class Program
{
    public static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        var level1 = new Level1();
        var level2 = new Level2();
        var level3 = new Level3();
        var level4 = new Level4();

        level1.SetNext(level2).SetNext(level3).SetNext(level4);

        level1.Handle();
    }
}