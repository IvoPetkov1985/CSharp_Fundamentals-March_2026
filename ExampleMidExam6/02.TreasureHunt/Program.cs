namespace _02.TreasureHunt
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
                List<string> arguments = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                string command = arguments[0];

                if (command == "Loot")
                {
                    List<string> newChest = arguments.Skip(1).ToList();

                    for (int i = 0; i < newChest.Count; i++)
                    {
                        string currentItem = newChest[i];

                        if (!treasureChest.Contains(currentItem))
                        {
                            treasureChest.Insert(0, currentItem);
                        }
                    }
                }
                else if (command == "Drop")
                {
                    int index = int.Parse(arguments[1]);

                    if (index >= 0 && index < treasureChest.Count)
                    {
                        string item = treasureChest[index];
                        treasureChest.RemoveAt(index);
                        treasureChest.Add(item);
                    }                    
                }
                else if (command == "Steal")
                {
                    int count = int.Parse(arguments[1]);
                    List<string> stolenItems = treasureChest.TakeLast(count).ToList();
                    treasureChest.RemoveRange(treasureChest.Count - stolenItems.Count, stolenItems.Count);
                    Console.WriteLine(string.Join(", ", stolenItems));
                }

                commandLine = Console.ReadLine();
            }

            if (treasureChest.Count > 0)
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
