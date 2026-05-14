using System.Text;

namespace _02.Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> usersContests = new();
            List<Contest> contests = new();

            string inputLine = Console.ReadLine();

            while (inputLine != "no more time")
            {
                string[] tokens = inputLine
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string username = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);

                Contest selectedContest = contests.FirstOrDefault(c => c.Name == contest);

                if (selectedContest == null)
                {
                    selectedContest = new Contest(contest);
                    contests.Add(selectedContest);
                }

                if (!selectedContest.Users.ContainsKey(username))
                {
                    selectedContest.Users.Add(username, points);
                }
                else
                {
                    if (points > selectedContest.Users[username])
                    {
                        selectedContest.Users[username] = points;
                    }
                }

                if (!usersContests.ContainsKey(username))
                {
                    usersContests.Add(username, new Dictionary<string, int>());
                }

                if (!usersContests[username].ContainsKey(contest))
                {
                    usersContests[username].Add(contest, points);
                }
                else
                {
                    if (usersContests[username][contest] < points)
                    {
                        usersContests[username][contest] = points;
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (Contest contest in contests)
            {
                Console.WriteLine(contest);
            }

            Console.WriteLine("Individual standings:");

            int individualPosition = 1;

            foreach (KeyValuePair<string, Dictionary<string, int>> participant in usersContests
                .OrderByDescending(kvp => kvp.Value.Sum(p => p.Value)).ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{individualPosition}. {participant.Key} -> {participant.Value.Sum(v => v.Value)}");
                individualPosition++;
            }
        }
    }

    public class Contest
    {
        public Contest(string name)
        {
            Name = name;
            Users = new Dictionary<string, int>();
        }

        public string Name { get; set; }

        public Dictionary<string, int> Users { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new();
            builder.AppendLine($"{Name}: {Users.Count} participants");
            int position = 1;

            foreach (KeyValuePair<string, int> participant in Users
                .OrderByDescending(u => u.Value)
                .ThenBy(u => u.Key))
            {
                builder.AppendLine($"{position}. {participant.Key} <::> {participant.Value}");
                position++;
            }

            return builder.ToString().TrimEnd();
        }
    }
}
