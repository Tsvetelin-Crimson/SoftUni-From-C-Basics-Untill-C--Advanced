using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Linq;

namespace Streams__Files_and_Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "input.txt"; // if anything above use Path.Combine();

            using (StreamReader streamReader = new StreamReader(input))
            {

                string line;
                int counter = 0;
                while ((line = streamReader.ReadLine()) != null)
                {

                    if (counter++ % 2 == 0)
                    {
                        string[] lineArr = line.Split(new string[] { "-", ",", ".", "!", "?" }, StringSplitOptions.RemoveEmptyEntries);

                        string result = string.Join('@', lineArr.Reverse());
                        //result = result.Reverse().ToString();
                        Console.WriteLine(result);
                    }
                    //Console.WriteLine(line);

                }

            }

        }
    }
}
