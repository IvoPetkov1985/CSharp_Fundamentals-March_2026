namespace _03.HeroesOfCodeAndLogicVII.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroesCount = int.Parse(Console.ReadLine());
            Hero[] heroes = new Hero[heroesCount];

            for (int i = 0; i < heroesCount; i++)
            {
                string inputLine = Console.ReadLine();
                string[] heroTokens = inputLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroName = heroTokens[0];
                int hitPoints = int.Parse(heroTokens[1]);
                int manaPoints = int.Parse(heroTokens[2]);
                Hero hero = new(heroName, hitPoints, manaPoints);
                heroes[i] = hero;
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "End")
            {
                string[] tokens = commandLine
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string name = tokens[1];
                Hero hero = heroes.First(h => h.Name == name);

                switch (command)
                {
                    case "CastSpell":
                        int mpNeeded = int.Parse(tokens[2]);
                        string spellName = tokens[3];

                        if (hero.ManaPoints >= mpNeeded)
                        {
                            hero.ManaPoints -= mpNeeded;
                            Console.WriteLine($"{name} has successfully cast {spellName} and now has {hero.ManaPoints} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                        }
                        break;
                    case "TakeDamage":
                        int damage = int.Parse(tokens[2]);
                        string attacker = tokens[3];
                        hero.HitPoints -= damage;

                        if (hero.HitPoints > 0)
                        {
                            Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {hero.HitPoints} HP left!");
                        }
                        else
                        {
                            hero.IsAlive = false;
                            Console.WriteLine($"{name} has been killed by {attacker}!");
                        }
                        break;
                    case "Recharge":
                        int amountManaPoints = int.Parse(tokens[2]);
                        int oldManaPoints = hero.ManaPoints;

                        if (oldManaPoints + amountManaPoints > 200)
                        {
                            amountManaPoints = 200 - oldManaPoints;
                        }

                        hero.ManaPoints += amountManaPoints;
                        Console.WriteLine($"{name} recharged for {amountManaPoints} MP!");
                        break;
                    case "Heal":
                        int amountHitPoints = int.Parse(tokens[2]);
                        int oldHitPoints = hero.HitPoints;

                        if (oldHitPoints + amountHitPoints > 100)
                        {
                            amountHitPoints = 100 - oldHitPoints;
                        }

                        hero.HitPoints += amountHitPoints;
                        Console.WriteLine($"{name} healed for {amountHitPoints} HP!");
                        break;
                }

                commandLine = Console.ReadLine();
            }

            foreach (Hero hero in heroes.Where(h => h.IsAlive))
            {
                Console.WriteLine(hero.Name);
                Console.WriteLine($"  HP: {hero.HitPoints}");
                Console.WriteLine($"  MP: {hero.ManaPoints}");
            }
        }

        class Hero
        {
            public Hero(string name, int hp, int mp)
            {
                this.Name = name;
                this.HitPoints = hp;
                this.ManaPoints = mp;
                this.IsAlive = true;
            }

            public string Name { get; set; }

            public int HitPoints { get; set; }

            public int ManaPoints { get; set; }

            public bool IsAlive { get; set; }
        }
    }
}
