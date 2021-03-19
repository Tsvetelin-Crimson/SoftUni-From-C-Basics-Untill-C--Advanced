using Microsoft.VisualBasic;
using System;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

namespace Streams__Files_and_Directories
{
    class LineN
    {
        static void Main(string[] args)
        {
            string input = Path.Combine("data", "input.txt"); 
            string output = Path.Combine("data", "output.txt");
            using StreamReader streamReader = new StreamReader(input);
            using StreamWriter streamWriter = new StreamWriter(output);

            string line;
            int counter = 0;

            while ((line = streamReader.ReadLine()) != null)
            {
                string newLine = $"Line {++counter}: " + line;

                streamWriter.WriteLine(newLine);
            }


        }
    }
}
