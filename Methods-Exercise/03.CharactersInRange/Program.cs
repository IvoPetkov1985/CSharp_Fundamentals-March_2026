namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            char minChar = GetCharWithMinValue(firstChar, secondChar);
            char maxChar = '\0';

            if (minChar == firstChar)
            {
                maxChar = secondChar;
            }
            else
            {
                maxChar = firstChar;
            }

            string result = GetLineOfChars(minChar, maxChar);
            Console.WriteLine(result.TrimEnd());
        }

        static char GetCharWithMinValue(char first, char second)
        {
            char minValueChar = (char)Math.Min(first, second);
            return minValueChar;
        }

        static string GetLineOfChars(char start, char end)
        {
            string line = string.Empty;

            for (int i = (int)start + 1; i < (int)end; i++)
            {
                line += $"{(char)i} ";
            }

            return line;
        }
    }
}
