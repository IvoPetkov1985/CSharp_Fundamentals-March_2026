using System.Text.RegularExpressions;

namespace _02.MirrorWords.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            Regex pairPattern = new(@"([\@\#])([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1");
            List<string> mirrorWords = new();

            MatchCollection pairs = pairPattern.Matches(inputText);

            foreach (Match match in pairs)
            {
                string firstWord = match.Groups[2].Value;
                string secondWord = match.Groups[3].Value;
                string reversed = new string(secondWord.Reverse().ToArray());

                if (firstWord == reversed)
                {
                    mirrorWords.Add($"{firstWord} <=> {secondWord}");
                }
            }

            if (pairs.Count > 0)
            {
                Console.WriteLine($"{pairs.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            if (mirrorWords.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWords));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
