namespace _03.P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new();

            string inputLine = Console.ReadLine();

            while (inputLine != "Sail")
            {
                string[] cityTokens = inputLine
                    .Split("||", StringSplitOptions.RemoveEmptyEntries);
                string name = cityTokens[0];
                int population = int.Parse(cityTokens[1]);
                int gold = int.Parse(cityTokens[2]);

                City city = cities.Find(c => c.Name == name);

                if (city != null)
                {
                    city.Population += population;
                    city.Gold += gold;
                }
                else
                {
                    city = new(name, population, gold);
                    cities.Add(city);
                }

                inputLine = Console.ReadLine();
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "End")
            {
                string[] tokens = commandLine
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string name = tokens[1];
                City city = cities.First(c => c.Name == name);

                switch (command)
                {
                    case "Plunder":
                        int people = int.Parse(tokens[2]);
                        int gold = int.Parse(tokens[3]);
                        city.Population -= people;
                        city.Gold -= gold;
                        Console.WriteLine($"{name} plundered! {gold} gold stolen, {people} citizens killed.");

                        if (city.Population == 0 || city.Gold == 0)
                        {
                            cities.Remove(city);
                            Console.WriteLine($"{name} has been wiped off the map!");
                        }

                        break;

                    case "Prosper":
                        int newGold = int.Parse(tokens[2]);

                        if (newGold >= 0)
                        {
                            city.Gold += newGold;
                            Console.WriteLine($"{newGold} gold added to the city treasury. {name} now has {city.Gold} gold.");
                        }
                        else
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }

                        break;
                }

                commandLine = Console.ReadLine();
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (City city in cities)
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

        class City
        {
            public City(string name, int population, int gold)
            {
                this.Name = name;
                this.Population = population;
                this.Gold = gold;
            }

            public string Name { get; set; }

            public int Population { get; set; }

            public int Gold { get; set; }
        }
    }
}
