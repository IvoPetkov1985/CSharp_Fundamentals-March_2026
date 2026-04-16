namespace _03.TreasureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string encrypredMessage = Console.ReadLine();

            while (encrypredMessage != "find")
            {
                string decrypredMessage = string.Empty;

                int index = 0;

                for (int i = 0; i < encrypredMessage.Length; i++)
                {
                    int key = keys[index];
                    char currentChar = encrypredMessage[i];
                    char newChar = (char)(currentChar - key);
                    decrypredMessage += newChar;
                    index++;

                    if (index == keys.Length)
                    {
                        index = 0;
                    }
                }

                int treasureStartIndex = decrypredMessage.IndexOf('&') + 1;
                int treasureEndIndex = decrypredMessage.LastIndexOf('&');
                string treasure = decrypredMessage.Substring(treasureStartIndex, treasureEndIndex - treasureStartIndex);

                int coordinatesStartIndex = decrypredMessage.IndexOf('<') + 1;
                int coordinatesEndIndex = decrypredMessage.IndexOf('>');
                string coordinates = decrypredMessage.Substring(coordinatesStartIndex, coordinatesEndIndex - coordinatesStartIndex);
                Console.WriteLine($"Found {treasure} at {coordinates}");

                encrypredMessage = Console.ReadLine();
            }
        }
    }
}
