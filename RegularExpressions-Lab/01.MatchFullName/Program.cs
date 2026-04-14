using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string allNames = Console.ReadLine();
            string namePattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            List<string> validNames = new();

            MatchCollection namesCollection = Regex.Matches(allNames, namePattern);

            foreach (Match name in namesCollection)
            {
                validNames.Add(name.Value);
            }

            Console.WriteLine(string.Join(" ", validNames));
        }
    }
}
