using System;
using System.Collections.Generic;
using System.Linq;

namespace Extract_File
{
    class ExtractF
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int indexOfFile = path.LastIndexOf('\\');
            string file = path.Substring(indexOfFile + 1);

            //Console.WriteLine(file);

            List<string> partsOfFile = file.Split('.').ToList();

            string extension = partsOfFile[partsOfFile.Count - 1];
            partsOfFile.RemoveAt(partsOfFile.Count - 1);
            string fileName = string.Join('.', partsOfFile);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
