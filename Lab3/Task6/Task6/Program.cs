using Task6;

internal class Program
{
    static async Task Main()
    {
        string url = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
        string bookText = await DownloadTextAsync(url);

        string[] lines = bookText.Split('\n');

        var factory = new FlyweightFactory();
        var root = new LightElementNode(factory.GetFlyweight("div", "block", false));

        long memoryBefore = GC.GetTotalMemory(true);

        for (int i = 0; i < lines.Length; i++)
        {
            string originalLine = lines[i]; 
            string trimmedLine = originalLine.TrimEnd(); 

            LightElementFlyweight flyweight;

            if (i == 0)
            {
                flyweight = factory.GetFlyweight("h1", "block", false);
            }
            else if (trimmedLine.Length < 20)
            {
                flyweight = factory.GetFlyweight("h2", "block", false);
            }
            else if (originalLine.StartsWith(" ") || originalLine.StartsWith("\t"))
            {
                flyweight = factory.GetFlyweight("blockquote", "block", false);
            }
            else
            {
                flyweight = factory.GetFlyweight("p", "block", false);
            }

            var element = new LightElementNode(flyweight);
            element.AddChild(new LightTextNode(trimmedLine)); 
            root.AddChild(element);
        }


        long memoryAfter = GC.GetTotalMemory(true);
        long memoryUsed = memoryAfter - memoryBefore;

        Console.WriteLine($"Memory used: {memoryUsed / 1024} KB");
        Console.WriteLine(root.OuterHTML());
    }

    static async Task<string> DownloadTextAsync(string url)
    {
        using var client = new HttpClient();
        return await client.GetStringAsync(url);
    }
}