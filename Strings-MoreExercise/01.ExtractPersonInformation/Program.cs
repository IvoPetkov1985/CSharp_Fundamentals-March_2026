using System.Text;

namespace _01.ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            StringBuilder result = new();

            for (int i = 0; i < linesCount; i++)
            {
                string inputLine = Console.ReadLine();

                int nameStartIndex = inputLine.IndexOf('@') + 1;
                int nameEndIndex = inputLine.IndexOf('|');
                string name = inputLine.Substring(nameStartIndex, nameEndIndex - nameStartIndex);

                int ageStartIndex = inputLine.IndexOf('#') + 1;
                int ageEndIndex = inputLine.IndexOf('*');
                string age = inputLine.Substring(ageStartIndex, ageEndIndex - ageStartIndex);

                result.AppendLine($"{name} is {age} years old.");
            }

            Console.WriteLine(result.ToString().TrimEnd());
        }
    }
}
