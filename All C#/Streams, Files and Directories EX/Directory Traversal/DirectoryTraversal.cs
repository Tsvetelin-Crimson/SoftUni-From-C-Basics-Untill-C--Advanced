using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Directory_Traversal
{
    class DirectoryTraversal
    {
        static void Main(string[] args)
        {
            string extension = Console.ReadLine();
            string filePath = "./";


            string[] filesNames = Directory.GetFiles(filePath, $"*{extension}*");

            Dictionary<string, Dictionary<string, double>> report = new Dictionary<string, Dictionary<string, double>>();

            foreach (string fileName in filesNames)
            {
                FileInfo currFile = new FileInfo(fileName);
                string currExtesion = currFile.Extension;
                double currSize = currFile.Length / 1024.0;
                string currName = currFile.Name;
                if (!report.ContainsKey(currExtesion))
                {
                    report[currExtesion] = new Dictionary<string, double>();
                }

                report[currExtesion].Add(currName, currSize);

                
            }
            report = report.OrderByDescending(k => k.Value.Count).ThenBy(k => k.Key).ToDictionary(k => k.Key, v => v.Value);

            StringBuilder sb = new StringBuilder();

            foreach ((string currExtension, Dictionary<string, double> fileData) in report)
            {
                sb.AppendLine(currExtension);               
                foreach ((string name, double size) in fileData)
                {
                    sb.AppendLine($"--{name} - {size:F3}kb");
                }
            }
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktopPath, "report.txt");

            File.WriteAllText(path, sb.ToString());

        }
    }
}
