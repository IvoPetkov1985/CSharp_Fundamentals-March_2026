namespace _03.HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroesCount = int.Parse(Console.ReadLine());
            List<Hero> heroes = new();

            for (int i = 0; i < heroesCount; i++)
            {
                string[] heroTokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = heroTokens[0];
                int hitPoints = int.Parse(heroTokens[1]);
                int manaPoints = int.Parse(heroTokens[2]);
                heroes.Add(new Hero(name, hitPoints, manaPoints));
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "End")
            {
                string[] tokens = commandLine
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string name = tokens[1];
                Hero hero = heroes.First(h => h.Name == name);

                if (command == "CastSpell")
                {
                    int mpNeeded = int.Parse(tokens[2]);
                    string spellName = tokens[3];
                    Console.WriteLine(hero.CastSpell(mpNeeded, spellName));
                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(tokens[2]);
                    string attackerName = tokens[3];
                    Console.WriteLine(hero.TakeDamage(damage, attackerName));
                }
                else if (command == "Recharge")
                {
                    int rechargeAmount = int.Parse(tokens[2]);
                    Console.WriteLine(hero.Recharge(rechargeAmount));
                }
                else if (command == "Heal")
                {
                    int healAmount = int.Parse(tokens[2]);
                    Console.WriteLine(hero.Heal(healAmount));
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

            public string CastSpell(int manaPoints, string spell)
            {
                if (this.ManaPoints >= manaPoints)
                {
                    ManaPoints -= manaPoints;
                    return $"{this.Name} has successfully cast {spell} and now has {this.ManaPoints} MP!";
                }

                return $"{this.Name} does not have enough MP to cast {spell}!";
            }

            public string TakeDamage(int damage, string attacker)
            {
                this.HitPoints -= damage;

                if (this.HitPoints > 0)
                {
                    return $"{this.Name} was hit for {damage} HP by {attacker} and now has {this.HitPoints} HP left!";
                }
                else
                {
                    IsAlive = false;
                    return $"{this.Name} has been killed by {attacker}!";
                }
            }

            public string Recharge(int amount)
            {
                if (this.ManaPoints + amount > 200)
                {
                    amount = 200 - this.ManaPoints;
                }

                this.ManaPoints += amount;
                return $"{this.Name} recharged for {amount} MP!";
            }

            public string Heal(int amount)
            {
                if (this.HitPoints + amount > 100)
                {
                    amount = 100 - this.HitPoints;
                }

                this.HitPoints += amount;
                return $"{this.Name} healed for {amount} HP!";
            }
        }
    }
}
