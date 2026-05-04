namespace _02.TreasureHunt.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> treasureChest = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string commandLine = Console.ReadLine();

            while (commandLine != "Yohoho!")
            {
                string[] tokens = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                if (command == "Loot")
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        string item = tokens[i];

                        if (!treasureChest.Contains(item))
                        {
                            treasureChest.Insert(0, item);
                        }
                    }
                }
                else if (command == "Drop")
                {
                    int index = int.Parse(tokens[1]);

                    if (index >= 0 && index < treasureChest.Count)
                    {
                        string itemToDrop = treasureChest[index];
                        treasureChest.RemoveAt(index);
                        treasureChest.Add(itemToDrop);
                    }
                }
                else if (command == "Steal")
                {
                    int count = int.Parse(tokens[1]);
                    string[] stolenElements = treasureChest.TakeLast(count).ToArray();
                    treasureChest.RemoveRange(treasureChest.Count - stolenElements.Length, stolenElements.Length);
                    Console.WriteLine(string.Join(", ", stolenElements));
                }

                commandLine = Console.ReadLine();
            }

            if (treasureChest.Any())
            {
                double averageGain = (treasureChest.Sum(t => t.Length) / (double)treasureChest.Count);
                Console.WriteLine($"Average treasure gain: {averageGain:F2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
