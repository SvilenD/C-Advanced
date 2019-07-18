namespace P06_ZipAndExtract2
{
    using System.IO;
    using System.IO.Compression;

    public class Program
    {
        public static void Main()
        {
            var sourceFile = "copyMe.png";
            var result = "../../../result.zip";

            using (var archive = ZipFile.Open(result, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(sourceFile, Path.GetFileName(sourceFile));
            }
        }
    }
}