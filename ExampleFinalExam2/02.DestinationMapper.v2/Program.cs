using System.Text.RegularExpressions;

namespace _02.DestinationMapper.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            Regex pattern = new Regex(@"(=|\/)(?<countryName>[A-Z][A-Za-z]{2,})\1");
            MatchCollection collection = pattern.Matches(inputText);
            int totalLengths = collection.Sum(t => t.Groups["countryName"].Value.Length);
            Console.WriteLine($"Destinations: {string.Join(", ", collection.Select(t => t.Groups["countryName"].Value))}");
            Console.WriteLine($"Travel Points: {totalLengths}");
        }
    }
}
