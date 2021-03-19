using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

namespace Streams__Files_and_Directories_EX
{
    class EvenLines
    {
        static void Main(string[] args)
        {
            string path = Path.Combine("data", "text.txt");


            using StreamReader streamReader = new StreamReader(path);

            string line = streamReader.ReadLine();
            int counter = 0;
            while (line != null)
            {
                if (counter % 2 == 0)
                {
                    string[] currLine = line.Split(new string[] { "-", ",", ".", "!", "?" }, StringSplitOptions.None);
                    string lineWithAt = string.Join("@", currLine);
                    string[] lineArr = lineWithAt.Split();
                    string invertedLine = string.Join(" ", lineArr.Reverse());
                    Console.WriteLine(invertedLine);
                }

                counter++;
                line = streamReader.ReadLine();
            }



        }
    }
}
