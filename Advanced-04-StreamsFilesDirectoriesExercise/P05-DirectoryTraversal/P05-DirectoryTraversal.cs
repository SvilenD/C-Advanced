namespace P06_FullDirectoryTraversal
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Enter folder path:");
            string path = Console.ReadLine();

            var files = Directory.GetFiles(path);

            var extensionsDict = new Dictionary<string, List<FileInfo>>();

            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                string extension = info.Extension;
                if (extensionsDict.ContainsKey(info.Extension) == false)
                {
                    extensionsDict.Add(info.Extension, new List<FileInfo>());
                }
                extensionsDict[info.Extension].Add(info);
            }

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter writer = new StreamWriter($"{desktopPath}/files.txt"))
            {
                foreach (var kvp in extensionsDict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    string ext = kvp.Key;
                    writer.WriteLine(ext);
                    List<FileInfo> infoList = kvp.Value;
                    foreach (var info in infoList.OrderByDescending(x => x.Length))
                    {
                        string name = info.Name;
                        double size = info.Length / 1024d; //Kb
                        writer.WriteLine($"--{name} - {size:f3}kb");
                    }
                }
            }
        }
    }
}