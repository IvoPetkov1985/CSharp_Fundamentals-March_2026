namespace _03.PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            Dictionary<string, int> plantsRarities = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantsRatings = new Dictionary<string, List<double>>();

            for (int i = 0; i < linesCount; i++)
            {
                string inputLine = Console.ReadLine();
                string[] plantTokens = inputLine
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plant = plantTokens[0];
                int rarity = int.Parse(plantTokens[1]);

                if (!plantsRarities.ContainsKey(plant))
                {
                    plantsRarities.Add(plant, rarity);
                    plantsRatings.Add(plant, new List<double>());
                }
                else
                {
                    plantsRarities[plant] = rarity;
                }
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "Exhibition")
            {
                string[] arguments = commandLine.Split(": ");
                string command = arguments[0];
                string[] tokens = arguments[1].Split(" - ");
                string plant = tokens[0];

                if (!plantsRarities.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    commandLine = Console.ReadLine();
                    continue;
                }

                if (command == "Rate")
                {
                    double rating = double.Parse(tokens[1]);
                    plantsRatings[plant].Add(rating);
                }
                else if (command == "Update")
                {
                    int newRarity = int.Parse(tokens[1]);
                    plantsRarities[plant] = newRarity;
                }
                else if (command == "Reset")
                {
                    plantsRatings[plant].Clear();
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (string plantName in plantsRarities.Keys)
            {
                double averageRating = 0;

                if (plantsRatings[plantName].Any())
                {
                    averageRating = plantsRatings[plantName].Average();
                }

                Console.WriteLine($"- {plantName}; Rarity: {plantsRarities[plantName]}; Rating: {averageRating:F2}");
            }
        }
    }
}
