namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            int startIndex = filePath.LastIndexOf(@"\") + 1;
            string fileInfo = filePath.Substring(startIndex);

            int extensionIndex = fileInfo.LastIndexOf(".") + 1;
            string fileName = fileInfo.Substring(0, extensionIndex - 1);
            string extensionName = fileInfo.Substring(extensionIndex);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extensionName}");
        }
    }
}
