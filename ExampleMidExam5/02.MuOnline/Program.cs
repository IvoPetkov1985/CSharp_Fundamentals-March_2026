namespace _02.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);

            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] arguments = rooms[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];
                int value = int.Parse(arguments[1]);

                switch (command)
                {
                    case "potion":
                        int oldHealth = health;
                        health += value;

                        if (health > 100)
                        {
                            health = 100;
                            value = 100 - oldHealth;
                        }

                        Console.WriteLine($"You healed for {value} hp.");
                        Console.WriteLine($"Current health: {health} hp.");

                        break;

                    case "chest":
                        bitcoins += value;
                        Console.WriteLine($"You found {value} bitcoins.");
                        break;

                    default:
                        health -= value;

                        if (health <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {command}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"You slayed {command}.");
                        }
                        break;
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
