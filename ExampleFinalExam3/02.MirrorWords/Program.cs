using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            Regex wordPattern = new Regex(@"([\@\#])(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1");

            Dictionary<string, string> mirrorWords = new Dictionary<string, string>();

            MatchCollection collection = wordPattern.Matches(inputText);
            int pairsFound = collection.Count;

            foreach (Match match in collection)
            {
                string firstWord = match.Groups["firstWord"].Value;
                string secondWord = match.Groups["secondWord"].Value;

                string reversedWord = new string(secondWord.ToCharArray().Reverse().ToArray());

                if (reversedWord == firstWord)
                {
                    mirrorWords.Add(firstWord, secondWord);
                }
            }

            if (pairsFound > 0)
            {
                Console.WriteLine($"{pairsFound} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                List<string> kvps = mirrorWords.Select(kvp => $"{kvp.Key} <=> {kvp.Value}").ToList();
                Console.WriteLine(string.Join(", ", kvps));
            }
        }
    }
}
