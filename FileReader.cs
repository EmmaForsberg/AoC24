using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aoc24
{
    internal class FileReader
    {
        private readonly string _filePath;

        public FileReader(string filePath)
        {
            _filePath = filePath;
        }

        public IEnumerable<string> ReadLines()
        {
            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException($"Filen {_filePath} hittades inte.");
            }

            return File.ReadLines(_filePath);
        }

        public string ReadAllText()
        {
            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException($"Filen {_filePath} hittades inte.");
            }

            return File.ReadAllText(_filePath);
        }
    }
}

