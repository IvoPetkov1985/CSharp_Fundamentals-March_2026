using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber.v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex phonePattern = new Regex(@"\+359([\- ])2\1\d{3}\1\d{4}\b");
            MatchCollection matches = phonePattern.Matches(input);

            string[] validPhones = matches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", validPhones));
        }
    }
}
