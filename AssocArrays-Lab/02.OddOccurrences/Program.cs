namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> occurrences = new();

            foreach (string word in words)
            {
                string wordToLower = word.ToLower();

                if (!occurrences.ContainsKey(wordToLower))
                {
                    occurrences[wordToLower] = 0;
                }

                occurrences[wordToLower]++;
            }

            List<string> selectedWords = new();

            foreach (KeyValuePair<string, int> kvp in occurrences)
            {
                if (kvp.Value % 2 != 0)
                {
                    selectedWords.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(" ", selectedWords));
        }
    }
}
