namespace _03.HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroesCount = int.Parse(Console.ReadLine());
            int maximumHP = 100;
            int maximumMP = 200;

            Dictionary<string, int> hpHeroes = new();
            Dictionary<string, int> mpHeroes = new();

            for (int i = 0; i < heroesCount; i++)
            {
                string inputLine = Console.ReadLine();
                string[] heroTokens = inputLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = heroTokens[0];
                int hitPoints = int.Parse(heroTokens[1]);
                int manaPoints = int.Parse(heroTokens[2]);

                hpHeroes.TryAdd(name, hitPoints);
                mpHeroes.TryAdd(name, manaPoints);
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "End")
            {
                string[] arguments = commandLine
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = arguments[0];
                string heroName = arguments[1];

                if (command == "CastSpell")
                {
                    int mpNeeded = int.Parse(arguments[2]);
                    string spellName = arguments[3];

                    if (mpHeroes[heroName] >= mpNeeded)
                    {
                        mpHeroes[heroName] -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {mpHeroes[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(arguments[2]);
                    string attacker = arguments[3];

                    hpHeroes[heroName] -= damage;

                    if (hpHeroes[heroName] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {hpHeroes[heroName]} HP left!");
                    }
                    else
                    {
                        hpHeroes.Remove(heroName);
                        mpHeroes.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (command == "Recharge")
                {
                    int rechargeAmount = int.Parse(arguments[2]);
                    int oldMP = mpHeroes[heroName];

                    if (oldMP + rechargeAmount > 200)
                    {
                        rechargeAmount = 200 - oldMP;
                    }

                    mpHeroes[heroName] += rechargeAmount;
                    Console.WriteLine($"{heroName} recharged for {rechargeAmount} MP!");
                }
                else if (command == "Heal")
                {
                    int healAmount = int.Parse(arguments[2]);
                    int oldHP = hpHeroes[heroName];

                    if (oldHP + healAmount > 100)
                    {
                        healAmount = 100 - oldHP;
                    }

                    hpHeroes[heroName] += healAmount;
                    Console.WriteLine($"{heroName} healed for {healAmount} HP!");
                }

                commandLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> hpHero in hpHeroes)
            {
                Console.WriteLine(hpHero.Key);
                Console.WriteLine($"  HP: {hpHero.Value}");
                Console.WriteLine($"  MP: {mpHeroes[hpHero.Key]}");
            }
        }
    }
}
