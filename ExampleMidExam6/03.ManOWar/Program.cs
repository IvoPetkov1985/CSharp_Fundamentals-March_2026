namespace _03.ManOWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] warship = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int maxHealth = int.Parse(Console.ReadLine());
            bool hasPirateShipWon = false;
            bool hasWarshipWon = false;

            string commandLine = Console.ReadLine();

            while (commandLine != "Retire")
            {
                string[] tokens = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                if (command == "Fire")
                {
                    int index = int.Parse(tokens[1]);
                    int damage = int.Parse(tokens[2]);

                    if (index >= 0 && index < warship.Length)
                    {
                        warship[index] -= damage;

                        if (warship[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            hasPirateShipWon = true;
                            break;
                        }
                    }
                }
                else if (command == "Defend")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    int damage = int.Parse(tokens[3]);

                    if (startIndex >= 0 && startIndex < pirateShip.Length &&
                        endIndex >= 0 && endIndex < pirateShip.Length)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;

                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                hasPirateShipWon = true;
                                break;
                            }
                        }

                        if (hasPirateShipWon)
                        {
                            break;
                        }
                    }
                }
                else if (command == "Repair")
                {
                    int index = int.Parse(tokens[1]);
                    int health = int.Parse(tokens[2]);

                    if (index >= 0 && index < pirateShip.Length)
                    {
                        pirateShip[index] += health;

                        if (pirateShip[index] > maxHealth)
                        {
                            pirateShip[index] = maxHealth;
                        }
                    }
                }
                else if (command == "Status")
                {
                    double criticalHealth = maxHealth * 0.2;
                    int sectionsToBeRepaired = Array.FindAll(pirateShip, x => x < criticalHealth).Length;
                    Console.WriteLine($"{sectionsToBeRepaired} sections need repair.");
                }

                commandLine = Console.ReadLine();
            }

            if (!hasPirateShipWon && !hasWarshipWon)
            {
                Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
                Console.WriteLine($"Warship status: {warship.Sum()}");
            }
        }
    }
}
