using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            Regex emojiPattern = new(@"(::|\*\*)([A-Z][a-z]{2,})\1");
            Regex digitPattern = new(@"\d");

            MatchCollection digitMatches = digitPattern.Matches(inputText);
            BigInteger digitsProduct = 1;

            foreach (Match digitMatch in digitMatches)
            {
                BigInteger digit = BigInteger.Parse(digitMatch.Value);
                digitsProduct *= digit;
            }

            MatchCollection emojisCollection = emojiPattern.Matches(inputText);
            List<string> coolEmojis = new();

            foreach (Match emojiMatch in emojisCollection)
            {
                string emoji = emojiMatch.Groups[2].Value;
                BigInteger asciiSum = 0;

                foreach (char letter in emoji)
                {
                    asciiSum += letter;
                }

                if (asciiSum > digitsProduct)
                {
                    coolEmojis.Add(emojiMatch.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {digitsProduct}");
            Console.WriteLine($"{emojisCollection.Count} emojis found in the text. The cool ones are:");

            if (coolEmojis.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, coolEmojis));
            }
        }
    }
}
