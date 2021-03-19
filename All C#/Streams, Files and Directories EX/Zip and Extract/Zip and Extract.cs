using System;
using System.IO;
using System.IO.Compression;

namespace Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileToCopyPath = Path.Combine("CopyMe", "copyMe.png");
            string fileDestinationPath = Path.Combine("CopyMe", "Zip.zip");
            //ZipFile.CreateFromDirectory(fileToCopyPath, fileDestinationPath);

            using ZipArchive zipArchive = ZipFile.Open(fileDestinationPath, ZipArchiveMode.Create);
            zipArchive.CreateEntryFromFile(fileToCopyPath, "newMe.png");
            string unzipDestinationPath = Path.Combine("UnzipHere");
            zipArchive.Dispose();

            using ZipArchive unzipArchive = ZipFile.Open(fileDestinationPath, ZipArchiveMode.Read);
            unzipArchive.ExtractToDirectory(unzipDestinationPath);

        }
    }
}
