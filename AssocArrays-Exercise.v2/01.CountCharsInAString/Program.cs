namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            Dictionary<char, int> charsCount = new();

            foreach (char letter in inputLine)
            {
                if (letter != ' ')
                {
                    if (!charsCount.ContainsKey(letter))
                    {
                        charsCount.Add(letter, 0);
                    }

                    charsCount[letter]++;
                }
            }

            foreach (KeyValuePair<char, int> letterInfo in charsCount)
            {
                Console.WriteLine($"{letterInfo.Key} -> {letterInfo.Value}");
            }
        }
    }
}
