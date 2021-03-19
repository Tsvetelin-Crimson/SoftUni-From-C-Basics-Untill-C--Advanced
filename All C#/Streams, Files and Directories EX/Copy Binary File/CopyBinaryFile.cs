using System;
using System.IO;

namespace Copy_Binary_File
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            string copyMePath = Path.Combine("ItemsToCopy", "copyMe.png");
            string copiedPath = Path.Combine("PlaceToCopy", "SoftUniLogo.png");


            using FileStream readFile = new FileStream(copyMePath, FileMode.Open);
            using FileStream writeFile = new FileStream(copiedPath, FileMode.Create);

            byte[] buffer = new byte[4096];

            if (readFile.CanRead)
            {
                int counter = readFile.Read(buffer, 0, buffer.Length);
                while (counter != 0)
                {
                    writeFile.Write(buffer);
                    counter = readFile.Read(buffer, 0, buffer.Length);
                }
            }

        }
    }
}
