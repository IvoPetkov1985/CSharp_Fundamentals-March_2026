using System.Text.RegularExpressions;

namespace _02.DestinationMapper.v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            Regex countryPattern = new(@"([=\/])([A-Z][A-Za-z]{2,})\1");
            Dictionary<string, int> countriesPoints = new();

            MatchCollection destinationMatches = countryPattern.Matches(inputText);

            foreach (Match match in destinationMatches)
            {
                string countryName = match.Groups[2].Value;
                countriesPoints.Add(countryName, countryName.Length);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", countriesPoints.Keys)}");
            Console.WriteLine($"Travel Points: {countriesPoints.Values.Sum()}");
        }
    }
}
