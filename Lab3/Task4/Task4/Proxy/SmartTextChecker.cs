using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Proxy
{
    public class SmartTextChecker : IService
    {
        private IService _realReader;

        public SmartTextChecker(IService realReader)
        {
            _realReader = realReader;
        }

        public char[][] ReadText(string filePath)
        {
            Console.WriteLine($"Opening file: {filePath}");

            char[][] content = _realReader.ReadText(filePath);

            Console.WriteLine($"File read successfully: {filePath}");
            Console.WriteLine($"Number of lines: {content.Length}");
            int totalCharacters = 0;
            foreach (var line in content)
            {
                totalCharacters += line.Length;
            }
            Console.WriteLine($"Total characters: {totalCharacters}");

            Console.WriteLine($"Closing file: {filePath}");
            return content;
        }
    }
}
