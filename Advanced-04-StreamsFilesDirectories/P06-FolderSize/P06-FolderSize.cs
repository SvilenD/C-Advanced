namespace P06_FolderSize
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            var folders = Directory.GetDirectories("../../../06. Folder Size");

            double folderSize = 0;
            foreach (var folder in folders)
            {
                var info = new DirectoryInfo(folder);

                foreach (var item in info.GetDirectories())
                {
                    Console.WriteLine(item);
                }
                var currentFolder = Directory.GetDirectories(folder);
                var files = Directory.GetFiles(folder);
                foreach (var file in files)
                {
                    var currentFile = new FileInfo(file);
                    double fileSize = currentFile.Length / 1024.0; //KB
                    Console.WriteLine($"{currentFile.FullName} - {fileSize:F2}KB");
                    folderSize += fileSize;
                }

                foreach (var subFolder in currentFolder)
                {
                    var subFiles = Directory.GetFiles(subFolder);
                    foreach (var file in subFiles)
                    {
                        var currentFile = new FileInfo(file);
                        double fileSize = currentFile.Length / 1024.0; //KB
                        Console.WriteLine($"{currentFile.FullName} - {(fileSize):F2}KB");

                        folderSize += fileSize;
                    }
                }
            }
            Console.WriteLine($"Folder size: {folderSize / 1024:F1}MB");
        }
    }
}