using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_3._2_Studio_Counting_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the library. Needs to be filled and have values initialized upon entering
            //Use a for loop to fill library
            //declare dictionary and new sentence variable
            Dictionary<char, int> dictionaryChars =
                new Dictionary<char, int>();
            string newSentence;
            int characterCount = 1;
            
            //request the sentence
            Console.WriteLine("Enter your sentence.");
            {
                Console.Write("sentence: ");
                newSentence = Console.ReadLine();
                if (newSentence != " ")
                {
                    //fill library
                    foreach (char letter in newSentence)
                    {
                        dictionaryChars.Add(letter, characterCount);
                        if (dictionaryChars.ContainsKey(letter))
                        {
                            int newCount = characterCount + 1;
                            dictionaryChars.Add(letter, newCount);
                        }
                    }
                }
            }
              
        }
    }
}
