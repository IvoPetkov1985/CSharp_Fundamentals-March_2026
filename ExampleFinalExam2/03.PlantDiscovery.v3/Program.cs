namespace _03.PlantDiscovery.v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesCounter = int.Parse(Console.ReadLine());
            List<Plant> plants = new();

            for (int i = 0; i < linesCounter; i++)
            {
                string[] plantTokens = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string name = plantTokens[0];
                int rarity = int.Parse(plantTokens[1]);
                Plant plant = plants.Find(p => p.Name == name);

                if (plant == null)
                {
                    plant = new(name, rarity);
                    plants.Add(plant);
                }
                else
                {
                    plant.Rarity = rarity;
                }
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "Exhibition")
            {
                string[] tokens = commandLine
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string[] commandTokens = tokens[1]
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string plantName = commandTokens[0];
                Plant plant = plants.Find(p => p.Name == plantName);

                if (plant == null)
                {
                    Console.WriteLine("error");
                    commandLine = Console.ReadLine();
                    continue;
                }

                if (command == "Rate")
                {
                    int rating = int.Parse(commandTokens[1]);
                    plant.Ratings.Add(rating);
                }
                else if (command == "Update")
                {
                    int newRarity = int.Parse(commandTokens[1]);
                    plant.Rarity = newRarity;
                }
                else if (command == "Reset")
                {
                    plant.Ratings.Clear();
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (Plant plant in plants)
            {
                double averageRating = 0;

                if (plant.Ratings.Count > 0)
                {
                    averageRating = plant.Ratings.Average();
                }

                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {averageRating:F2}");
            }
        }

        class Plant
        {
            public Plant(string name, int rarity)
            {
                this.Name = name;
                this.Rarity = rarity;
                this.Ratings = new List<int>();
            }

            public string Name { get; set; }

            public int Rarity { get; set; }

            public ICollection<int> Ratings { get; set; }
        }
    }
}
