using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            Regex pattern = new(@"(=|\/)([A-Z][A-Za-z]{2,})\1");
            Dictionary<string, int> destinationsPoints = new();

            MatchCollection collection = pattern.Matches(inputText);

            foreach (Match match in collection)
            {
                string destination = match.Groups[2].Value;
                int points = destination.Length;
                destinationsPoints.TryAdd(destination, points);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinationsPoints.Keys)}");
            Console.WriteLine($"Travel Points: {destinationsPoints.Values.Sum()}");
        }
    }
}
