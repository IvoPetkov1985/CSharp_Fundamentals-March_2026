namespace _03.ExtractFile.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            string fileInfo = inputLine.Split('\\').Last();
            string[] fileTokens = fileInfo.Split('.');
            string fileName = fileTokens[0];
            string extensionName = fileTokens[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extensionName}");
        }
    }
}
