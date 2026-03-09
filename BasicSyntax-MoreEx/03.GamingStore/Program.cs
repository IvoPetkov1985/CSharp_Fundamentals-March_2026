namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> games = new()
            {
                { "OutFall 4", 39.99 },
                { "CS: OG", 15.99 },
                { "Zplinter Zell", 19.99 },
                { "Honored 2", 59.99 },
                { "RoverWatch", 29.99 },
                { "RoverWatch Origins Edition", 39.99 }
            };

            double budget = double.Parse(Console.ReadLine());
            double currentBalance = budget;

            while (true)
            {
                string game = Console.ReadLine();

                if (game == "Game Time")
                {
                    double totalSpent = budget - currentBalance;
                    Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${currentBalance:F2}");
                    break;
                }

                if (games.ContainsKey(game) == false)
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                double currentPrice = games[game];

                if (currentPrice > currentBalance)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                else
                {
                    currentBalance -= currentPrice;
                    Console.WriteLine($"Bought {game}");
                }

                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
        }
    }
}
