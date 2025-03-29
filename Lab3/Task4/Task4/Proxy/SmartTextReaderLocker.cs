using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4.Proxy
{
    public class SmartTextReaderLocker : IService
    {
        private IService _realReader;
        private Regex _fileAccessPattern;

        public SmartTextReaderLocker(IService realReader, string pattern)
        {
            _realReader = realReader;
            _fileAccessPattern = new Regex(pattern);
        }

        public char[][] ReadText(string filePath)
        {
            if (!_fileAccessPattern.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return new char[0][];
            }

            return _realReader.ReadText(filePath);
        }
    }
}
