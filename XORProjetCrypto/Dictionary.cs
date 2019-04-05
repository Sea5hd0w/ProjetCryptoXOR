using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XORProjetCrypto
{
    class Dictionary
    {
        public List<string> words = new List<string>();

        public Dictionary(string path)
        {
            string[] logFile = File.ReadAllLines(path);
            words = new List<string>(logFile);

            Console.WriteLine(words.Count);
        }

        public double CheckString(string line)
        {
            double count = 0;
            if(line.IndexOf("bonjour", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                count = Math.Pow("bonjour".Length, 3);
            }

            /*
            double count = 0;
            foreach(string word in words)
            {
                if (line.Contains(word)) count = count + Math.Pow(word.Length, 3);
            }*/
            return count;
        }
    }
}
