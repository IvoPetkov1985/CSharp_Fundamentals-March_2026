namespace _03.ManOWar.v2
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

            int healthCapacity = int.Parse(Console.ReadLine());

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

                    if (IsIndexValid(index, warship.Length))
                    {
                        warship[index] -= damage;

                        if (warship[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (command == "Defend")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    int damage = int.Parse(tokens[3]);

                    if (IsIndexValid(startIndex, pirateShip.Length) &&
                        IsIndexValid(endIndex, pirateShip.Length) &&
                        endIndex > startIndex)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;

                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (command == "Repair")
                {
                    int index = int.Parse(tokens[1]);
                    int health = int.Parse(tokens[2]);

                    if (IsIndexValid(index, pirateShip.Length))
                    {
                        pirateShip[index] += health;

                        if (pirateShip[index] > healthCapacity)
                        {
                            pirateShip[index] = healthCapacity;
                        }
                    }
                }
                else if (command == "Status")
                {
                    double criticalHealth = healthCapacity * 0.2;
                    int sections = pirateShip.Where(x => x < criticalHealth).Count();
                    Console.WriteLine($"{sections} sections need repair.");
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warship.Sum()}");
        }

        static bool IsIndexValid(int index, int length)
        {
            return index >= 0 && index < length;
        }
    }
}
