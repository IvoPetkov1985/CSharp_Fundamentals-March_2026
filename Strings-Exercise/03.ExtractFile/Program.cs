namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            int fileNameIndex = filePath.LastIndexOf('\\');
            int fileExtensionIndex = filePath.LastIndexOf('.');

            string fileName = filePath.Substring(fileNameIndex + 1, fileExtensionIndex - fileNameIndex - 1);
            string extension = filePath.Substring(fileExtensionIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
