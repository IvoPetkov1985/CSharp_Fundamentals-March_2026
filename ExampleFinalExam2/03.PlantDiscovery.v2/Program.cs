namespace _03.PlantDiscovery.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            List<Plant> plants = new List<Plant>();

            for (int i = 0; i < linesCount; i++)
            {
                string inputLine = Console.ReadLine();
                string[] inputTokens = inputLine
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plantSpecies = inputTokens[0];
                int rarity = int.Parse(inputTokens[1]);

                Plant searchedPlant = plants.FirstOrDefault(p => p.Name == plantSpecies);

                if (searchedPlant != null)
                {
                    searchedPlant.Rarity = rarity;
                }
                else
                {
                    searchedPlant = new Plant();
                    searchedPlant.Name = plantSpecies;
                    searchedPlant.Rarity = rarity;
                    plants.Add(searchedPlant);
                }
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "Exhibition")
            {
                string[] arguments = commandLine
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];
                string[] tokens = arguments[1]
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string plantName = tokens[0];
                Plant plant = plants.FirstOrDefault(p => p.Name == plantName);

                if (plant == null)
                {
                    Console.WriteLine("error");
                    commandLine = Console.ReadLine();
                    continue;
                }

                if (command == "Rate")
                {
                    double rating = double.Parse(tokens[1]);
                    plant.Ratings.Add(rating);
                }
                else if (command == "Update")
                {
                    int newRarity = int.Parse(tokens[1]);
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
            public Plant()
            {
                Ratings = new List<double>();
            }

            public string Name { get; set; }

            public int Rarity { get; set; }

            public List<double> Ratings { get; set; }
        }
    }
}
