using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            int caloriesPerDay = 2_000;

            Regex pattern = new(@"(#|\|)(?<item>[A-Za-z ]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1");

            MatchCollection collection = pattern.Matches(inputText);

            int caloriesSum = collection.Sum(c => int.Parse(c.Groups["calories"].Value));
            int days = caloriesSum / caloriesPerDay;
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match match in collection)
            {
                string itemName = match.Groups["item"].Value;
                string expirationDate = match.Groups["date"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);

                Console.WriteLine($"Item: {itemName}, Best before: {expirationDate}, Nutrition: {calories}");
            }
        }
    }
}
