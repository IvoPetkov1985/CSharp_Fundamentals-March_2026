namespace _03.MOBAChallenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playerPool = new();

            string inputLine = Console.ReadLine();

            while (inputLine != "Season end")
            {
                if (inputLine.Contains(" -> "))
                {
                    string[] tokens = inputLine
                        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string player = tokens[0];
                    string position = tokens[1];
                    int skill = int.Parse(tokens[2]);

                    if (!playerPool.ContainsKey(player))
                    {
                        playerPool.Add(player, new Dictionary<string, int>());
                        playerPool[player].Add(position, skill);
                    }
                    else
                    {
                        if (!playerPool[player].ContainsKey(position))
                        {
                            playerPool[player].Add(position, skill);
                        }
                        else
                        {
                            if (playerPool[player][position] < skill)
                            {
                                playerPool[player][position] = skill;
                            }
                        }
                    }
                }
                else if (inputLine.Contains(" vs "))
                {
                    string[] battleTokens = inputLine
                        .Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    string firstPlayer = battleTokens[0];
                    string secondPlayer = battleTokens[1];

                    if (playerPool.ContainsKey(firstPlayer) && playerPool.ContainsKey(secondPlayer))
                    {
                        bool hasCommonPosition = playerPool[firstPlayer].Keys
                            .Any(p => playerPool[secondPlayer].ContainsKey(p));

                        if (hasCommonPosition)
                        {
                            int firstTotalSkill = playerPool[firstPlayer].Values.Sum();
                            int secondTotalSkill = playerPool[secondPlayer].Values.Sum();

                            if (firstTotalSkill > secondTotalSkill)
                            {
                                playerPool.Remove(secondPlayer);
                            }
                            else if (firstTotalSkill < secondTotalSkill)
                            {
                                playerPool.Remove(firstPlayer);
                            }
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> player in playerPool
                .OrderByDescending(kvp => kvp.Value.Sum(s => s.Value)).ThenBy(kvp => kvp.Key))
            {
                int totalSkill = player.Value.Sum(s => s.Value);
                Console.WriteLine($"{player.Key}: {totalSkill} skill");

                foreach (KeyValuePair<string, int> kvp in player.Value
                    .OrderByDescending(k => k.Value).ThenBy(k => k.Key))
                {
                    Console.WriteLine($"- {kvp.Key} <::> {kvp.Value}");
                }
            }
        }
    }
}
