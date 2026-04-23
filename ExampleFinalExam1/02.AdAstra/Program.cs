using System.Text;
using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            int neededCaloriesPerDay = 2000;
            int totalCalories = 0;

            Regex pattern = new(@"(#|\|)(?<product>[A-Za-z ]+)\1(?<date>\d{2}/\d{2}/\d{2})\1(?<calories>\d+)\1");
            MatchCollection collection = pattern.Matches(inputText);

            foreach (Match match in collection)
            {
                int calories = int.Parse(match.Groups["calories"].Value);
                totalCalories += calories;
            }

            int daysLast = totalCalories / neededCaloriesPerDay;

            StringBuilder builder = new();
            builder.AppendLine($"You have food to last you for: {daysLast} days!");

            if (collection.Any())
            {
                foreach (Match match in collection)
                {
                    string product = match.Groups["product"].Value;
                    string bestBefore = match.Groups["date"].Value;
                    int calories = int.Parse(match.Groups["calories"].Value);
                    builder.AppendLine($"Item: {product}, Best before: {bestBefore}, Nutrition: {calories}");
                }
            }

            Console.WriteLine(builder.ToString().TrimEnd());
        }
    }
}
