using System.Text;

namespace _01.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestsPasswords = new();

            string inputLine = Console.ReadLine();

            while (inputLine != "end of contests")
            {
                string[] contestTokens = inputLine
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = contestTokens[0];
                string password = contestTokens[1];
                contestsPasswords.Add(contest, password);

                inputLine = Console.ReadLine();
            }

            List<Participant> participants = new();

            string submissionLine = Console.ReadLine();

            while (submissionLine != "end of submissions")
            {
                string[] submissionTokens = submissionLine
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = submissionTokens[0];
                string password = submissionTokens[1];
                string username = submissionTokens[2];
                int points = int.Parse(submissionTokens[3]);

                if (!contestsPasswords.ContainsKey(contest))
                {
                    submissionLine = Console.ReadLine();
                    continue;
                }

                if (contestsPasswords[contest] != password)
                {
                    submissionLine = Console.ReadLine();
                    continue;
                }

                Participant user = participants.FirstOrDefault(u => u.Username == username);

                if (user != null)
                {
                    if (user.ContestsPoints.ContainsKey(contest))
                    {
                        if (points > user.ContestsPoints[contest])
                        {
                            user.ContestsPoints[contest] = points;
                        }
                    }
                    else
                    {
                        user.ContestsPoints.Add(contest, points);
                    }
                }
                else
                {
                    user = new Participant(username);
                    user.ContestsPoints.Add(contest, points);
                    participants.Add(user);
                }

                submissionLine = Console.ReadLine();
            }

            int bestPoints = 0;
            Participant bestParticipant = null;

            foreach (Participant participant in participants)
            {
                int currentPoints = participant.GetTotalPoints();

                if (currentPoints > bestPoints)
                {
                    bestPoints = currentPoints;
                    bestParticipant = participant;
                }
            }

            Console.WriteLine($"Best candidate is {bestParticipant.Username} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (Participant participant in participants
                .OrderBy(p => p.Username))
            {
                Console.WriteLine(participant);
            }
        }
    }

    public class Participant
    {
        public Participant(string name)
        {
            Username = name;
            ContestsPoints = new Dictionary<string, int>();
        }

        public string Username { get; set; }

        public Dictionary<string, int> ContestsPoints { get; set; }

        public int GetTotalPoints()
        {
            return ContestsPoints.Sum(p => p.Value);
        }

        public override string ToString()
        {
            StringBuilder builder = new();
            builder.AppendLine(Username);

            foreach (KeyValuePair<string, int> contestInfo in ContestsPoints
                .OrderByDescending(kvp => kvp.Value))
            {
                builder.AppendLine($"#  {contestInfo.Key} -> {contestInfo.Value}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}
