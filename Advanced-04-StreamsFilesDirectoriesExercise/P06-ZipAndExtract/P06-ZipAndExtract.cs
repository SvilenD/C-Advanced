namespace ZipAndExtract
{
    using System.IO.Compression;

    public class Program
    {
        public static void Main()
        {
            string contentPath = "../../.././ZipFolder";
            string zipPath = "../../../Result.zip";
            string extractPath = @"../../../ExtractFolder";

            ZipFile.CreateFromDirectory(contentPath, zipPath);

            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
    }
}