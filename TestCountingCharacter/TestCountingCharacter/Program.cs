using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCountingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dictionaryChars =
                new Dictionary<char, int>();
            string sentence = "abcdefghijk";
            int characterCount = 0;
            foreach (char letter in sentence)
            {
                dictionaryChars.Add(letter, characterCount);
            }
            Console.WriteLine(dictionaryChars);
            Console.ReadLine();
        }
    }
}
