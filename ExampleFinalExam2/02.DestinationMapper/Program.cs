using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            Regex pattern = new Regex(@"(\=|\/)[A-Z][A-Za-z]{2,}\1");
            MatchCollection collection = pattern.Matches(inputText);
            int totalLengths = 0;
            List<string> countries = new List<string>();

            foreach (Match match in collection)
            {
                string country = match.Value.Substring(1, match.Value.Length - 2);
                countries.Add(country);
                totalLengths += country.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", countries)}");
            Console.WriteLine($"Travel Points: {totalLengths}");
        }
    }
}
