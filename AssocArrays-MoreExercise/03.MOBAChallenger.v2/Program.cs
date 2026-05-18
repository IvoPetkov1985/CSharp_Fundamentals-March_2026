using System.Text;

namespace _03.MOBAChallenger.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            string inputLine = Console.ReadLine();

            while (inputLine != "Season end")
            {
                if (inputLine.Contains(" -> "))
                {
                    string[] playerTokens = inputLine
                        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string playerName = playerTokens[0];
                    string position = playerTokens[1];
                    int skill = int.Parse(playerTokens[2]);

                    Player player = players.FirstOrDefault(p => p.Name == playerName);

                    if (player == null)
                    {
                        player = new Player(playerName);
                        players.Add(player);
                    }

                    if (!player.PositionsSkills.ContainsKey(position))
                    {
                        player.PositionsSkills.Add(position, skill);
                    }
                    else
                    {
                        if (skill > player.PositionsSkills[position])
                        {
                            player.PositionsSkills[position] = skill;
                        }
                    }
                }
                else if (inputLine.Contains(" vs "))
                {
                    string[] names = inputLine
                        .Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    string firstName = names[0];
                    string secondName = names[1];
                    Player firstPlayer = players.FirstOrDefault(p => p.Name == firstName);
                    Player secondPlayer = players.FirstOrDefault(p => p.Name == secondName);

                    if (firstPlayer != null && secondPlayer != null)
                    {
                        if (firstPlayer.PositionsSkills.Keys.Any(p => secondPlayer.PositionsSkills.ContainsKey(p)))
                        {
                            if (firstPlayer.TotalSkillPoints > secondPlayer.TotalSkillPoints)
                            {
                                players.Remove(secondPlayer);
                            }
                            else if (firstPlayer.TotalSkillPoints < secondPlayer.TotalSkillPoints)
                            {
                                players.Remove(firstPlayer);
                            }
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (Player player in players
                .OrderByDescending(p => p.TotalSkillPoints)
                .ThenBy(p => p.Name))
            {
                Console.WriteLine(player);
            }
        }
    }

    public class Player
    {
        public Player(string name)
        {
            Name = name;
            PositionsSkills = new Dictionary<string, int>();
        }

        public string Name { get; set; }

        public int TotalSkillPoints
         => PositionsSkills.Values.Sum();

        public Dictionary<string, int> PositionsSkills { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{Name}: {TotalSkillPoints} skill");

            foreach (KeyValuePair<string, int> positionInfo in PositionsSkills
                .OrderByDescending(p => p.Value)
                .ThenBy(p => p.Key))
            {
                builder.AppendLine($"- {positionInfo.Key} <::> {positionInfo.Value}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}
