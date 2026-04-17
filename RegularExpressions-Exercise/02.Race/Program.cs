using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string inputLine = Console.ReadLine();

            Regex letterPattern = new(@"[A-Za-z]+");
            Regex digitPattern = new(@"\d");
            Dictionary<string, int> race = new();

            while (inputLine != "end of race")
            {
                MatchCollection lettersCollection = letterPattern.Matches(inputLine);
                string name = string.Empty;

                foreach (Match letters in lettersCollection)
                {
                    name += letters.Value;
                }

                int points = 0;

                if (participants.Contains(name))
                {
                    MatchCollection digits = digitPattern.Matches(inputLine);

                    foreach (Match digit in digits)
                    {
                        int number = int.Parse(digit.Value);
                        points += number;
                    }

                    if (!race.ContainsKey(name))
                    {
                        race.Add(name, 0);
                    }

                    race[name] += points;
                }

                inputLine = Console.ReadLine();
            }

            int counter = 0;
            
            foreach (var kvp in race.OrderByDescending(x => x.Value))
            {
                counter++;
                if (counter == 1)
                    Console.WriteLine($"1st place: {kvp.Key}");
                else if (counter == 2)
                    Console.WriteLine($"2nd place: {kvp.Key}");
                else if (counter == 3)
                    Console.WriteLine($"3rd place: {kvp.Key}");

                if (counter == 4)
                    break;
            }
        }
    }
}
