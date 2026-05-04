namespace _02.MuOnline.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dungeon = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);

            int maxHealth = 100;
            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < dungeon.Length; i++)
            {
                string[] room = dungeon[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = room[0];
                int amount = int.Parse(room[1]);

                switch (command)
                {
                    case "potion":

                        if (health + amount > maxHealth)
                        {
                            amount = maxHealth - health;
                        }

                        health += amount;
                        Console.WriteLine($"You healed for {amount} hp.");
                        Console.WriteLine($"Current health: {health} hp.");

                        break;
                    case "chest":
                        bitcoins += amount;
                        Console.WriteLine($"You found {amount} bitcoins.");
                        break;
                    default:
                        string monster = command;
                        health -= amount;

                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {monster}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {monster}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            return;
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
