namespace _02.TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> treasureChest = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string inputLine = Console.ReadLine();

            while (inputLine != "Yohoho!")
            {
                string[] arguments = inputLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];

                if (command == "Loot")
                {
                    List<string> items = arguments.Skip(1).ToList();

                    for (int i = 0; i < items.Count; i++)
                    {
                        if (!treasureChest.Contains(items[i]))
                        {
                            treasureChest.Insert(0, items[i]);
                        }
                    }
                }
                else if (command == "Drop")
                {
                    int index = int.Parse(arguments[1]);

                    if (index >= 0 && index < treasureChest.Count)
                    {
                        string loot = treasureChest[index];
                        treasureChest.RemoveAt(index);
                        treasureChest.Add(loot);
                    }
                }
                else if (command == "Steal")
                {
                    int count = int.Parse(arguments[1]);
                    List<string> stolenLoots = treasureChest.TakeLast(count).ToList();
                    treasureChest.RemoveRange(treasureChest.Count - stolenLoots.Count, stolenLoots.Count);
                    Console.WriteLine(string.Join(", ", stolenLoots));
                }

                inputLine = Console.ReadLine();
            }

            if (treasureChest.Any())
            {
                double sumLengths = treasureChest.Sum(t => t.Length);
                double averageGain = sumLengths / treasureChest.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:F2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
