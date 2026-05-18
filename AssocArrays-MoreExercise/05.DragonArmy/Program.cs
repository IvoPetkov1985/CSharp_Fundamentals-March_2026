namespace _05.DragonArmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, Dragon>> dragonTypeRegistry = new Dictionary<string, SortedDictionary<string, Dragon>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string type = tokens[0];
                string name = tokens[1];
                int damage = tokens[2] == "null" ? 45 : int.Parse(tokens[2]);
                int health = tokens[3] == "null" ? 250 : int.Parse(tokens[3]);
                int armor = tokens[4] == "null" ? 10 : int.Parse(tokens[4]);

                if (!dragonTypeRegistry.ContainsKey(type))
                {
                    dragonTypeRegistry[type] = new SortedDictionary<string, Dragon>();
                }

                if (!dragonTypeRegistry[type].ContainsKey(name))
                {
                    dragonTypeRegistry[type][name] = new Dragon();
                }

                dragonTypeRegistry[type][name].Damage = damage;
                dragonTypeRegistry[type][name].Health = health;
                dragonTypeRegistry[type][name].Armor = armor;
            }

            foreach (KeyValuePair<string, SortedDictionary<string, Dragon>> typeKvp in dragonTypeRegistry)
            {
                string type = typeKvp.Key;
                SortedDictionary<string, Dragon> dragonsInType = typeKvp.Value;

                double avgDamage = dragonsInType.Values.Average(d => d.Damage);
                double avgHealth = dragonsInType.Values.Average(d => d.Health);
                double avgArmor = dragonsInType.Values.Average(d => d.Armor);

                Console.WriteLine($"{type}::({avgDamage:F2}/{avgHealth:F2}/{avgArmor:F2})");

                foreach (KeyValuePair<string, Dragon> dragonKvp in dragonsInType)
                {
                    string name = dragonKvp.Key;
                    Dragon stats = dragonKvp.Value;
                    Console.WriteLine($"-{name} -> damage: {stats.Damage}, health: {stats.Health}, armor: {stats.Armor}");
                }
            }
        }
    }

    class Dragon
    {
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }
}
