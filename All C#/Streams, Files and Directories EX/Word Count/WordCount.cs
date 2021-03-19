using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word_Count
{
    class WordCount
    {
        static void Main(string[] args)
        {
            string textPath = Path.Combine("data", "text.txt"); //i know it, could have looked better with methods
            string wordsPath = Path.Combine("data", "words.txt");
            string[] words = File.ReadAllLines(wordsPath);
            
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordsCount[word.ToLower()] = 0;
            }

            string[] text = File.ReadAllLines(textPath);
            foreach (string line in text)
            {
                string[] lineWords = line.Split(new char[] { ' ', '.', '?', '!', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in lineWords)
                {
                    if (wordsCount.ContainsKey(word.ToLower()))
                    {
                        wordsCount[word.ToLower()]++;
                    }
                }
            }
            List<string> actualResultWords = new List<string>();
            foreach ((string word, int count) in wordsCount)
            {
                string currWord = $"{word} - {count}";
                actualResultWords.Add(currWord);
            }
            string actResult = Path.Combine("data", "actualResult.txt");
            File.WriteAllLines(actResult, actualResultWords);

            wordsCount = wordsCount.OrderByDescending(k => k.Value).ToDictionary(k => k.Key, v => v.Value);

            List<string> expectedResultWords = new List<string>();
            foreach ((string word, int count) in wordsCount)
            {
                string currWord = $"{word} - {count}";
                expectedResultWords.Add(currWord);
            }
            string expResult = Path.Combine("data", "expectedResult.txt");
            File.WriteAllLines(expResult, expectedResultWords);


        }
    }
}
