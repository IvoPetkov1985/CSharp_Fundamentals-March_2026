using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string allDates = Console.ReadLine();
            string datePattern = @"\b(?<day>\d{2})([/\-\.])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            MatchCollection collection = Regex.Matches(allDates, datePattern);

            foreach (Match date in collection)
            {
                int day = int.Parse(date.Groups["day"].Value);
                string month = date.Groups["month"].Value;
                int year = int.Parse(date.Groups["year"].Value);

                Console.WriteLine($"Day: {day:D2}, Month: {month}, Year: {year}");
            }
        }
    }
}
