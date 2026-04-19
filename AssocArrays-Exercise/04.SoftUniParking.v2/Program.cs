using System.Text;

namespace _04.SoftUniParking.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingLot = new();
            StringBuilder builder = new();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] commandTokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandTokens[0];
                string username = commandTokens[1];

                switch (command)
                {
                    case "register":
                        string licensePlateNumber = commandTokens[2];

                        if (!parkingLot.ContainsKey(username))
                        {
                            parkingLot[username] = licensePlateNumber;
                            builder.AppendLine($"{username} registered {licensePlateNumber} successfully");
                        }
                        else
                        {
                            builder.AppendLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        }

                        break;

                    case "unregister":
                        bool isRemoved = parkingLot.Remove(username);

                        if (isRemoved)
                        {
                            builder.AppendLine($"{username} unregistered successfully");
                        }
                        else
                        {
                            builder.AppendLine($"ERROR: user {username} not found");
                        }

                        break;
                }
            }

            foreach (KeyValuePair<string, string> userInfo in parkingLot)
            {
                builder.AppendLine($"{userInfo.Key} => {userInfo.Value}");
            }

            Console.WriteLine(builder.ToString().TrimEnd());
        }
    }
}
