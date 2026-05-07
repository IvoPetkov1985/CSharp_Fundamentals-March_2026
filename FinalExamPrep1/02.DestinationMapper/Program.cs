using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new(@"(=|\/)([A-Z][A-Za-z]{2,})\1");

            MatchCollection collection = regex.Matches(input);

            string result = string.Join(", ", collection.Select(x => x.Groups[2].Value));
            int points = collection.Sum(x => x.Groups[2].Value.Length);

            Console.WriteLine($"Destinations: {result}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
