namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> occurrences = new();

            foreach (char letter in text)
            {
                if (letter == ' ')
                {
                    continue;
                }

                if (!occurrences.ContainsKey(letter))
                {
                    occurrences.Add(letter, 0);
                }

                occurrences[letter]++;
            }

            foreach (KeyValuePair<char, int> kvp in occurrences)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
