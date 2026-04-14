using System.Text.RegularExpressions;

namespace _03.MatchDates.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex datePattern = new Regex(@"\b(?<day>\d{2})([/\-\.])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");
            MatchCollection matches = datePattern.Matches(input);

            foreach (Match date in matches)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
