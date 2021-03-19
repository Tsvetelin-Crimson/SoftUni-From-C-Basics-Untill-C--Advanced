using System;
using System.Collections.Generic;
using System.IO;

namespace Line_Numbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string path = Path.Combine("data", "text.txt");
            string outputPath = Path.Combine("data", "output.txt");
      
            string[] file = File.ReadAllLines(path);
            int letters = 0;
            int punctuationMarks = 0;
            int lineCounter = 1;
            List<string> newLines = new List<string>();
            foreach (string line in file)
            {
                foreach (char c in line)
                {
                    if (char.IsLetter(c))
                    {
                        letters++;
                    }
                    else if (char.IsPunctuation(c))
                    {
                        punctuationMarks++;
                    }                   
                }
                
                string newLine = $"Line {lineCounter}:{line}({letters})({punctuationMarks}) ";
                newLines.Add(newLine);
                File.WriteAllLines(outputPath, newLines);
                lineCounter++;
                letters = 0;
                punctuationMarks = 0;
            }

        }
    }
}
