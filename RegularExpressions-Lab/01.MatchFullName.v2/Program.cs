using System.Text.RegularExpressions;

namespace _01.MatchFullName.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            MatchCollection matches = pattern.Matches(input);
            IEnumerable<string> validNames = matches.Select(m => m.Value);
            Console.WriteLine(string.Join(" ", validNames));
        }
    }
}
