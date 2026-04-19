namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> namesCars = new();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string inputLine = Console.ReadLine();
                string[] tokens = inputLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string username = tokens[1];

                if (command == "register")
                {
                    string licensePlateNumber = tokens[2];

                    if (!namesCars.ContainsKey(username))
                    {
                        namesCars.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {namesCars[username]}");
                    }
                }
                else if (command == "unregister")
                {
                    if (namesCars.ContainsKey(username))
                    {
                        namesCars.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (KeyValuePair<string, string> userInfo in namesCars)
            {
                Console.WriteLine($"{userInfo.Key} => {userInfo.Value}");
            }
        }
    }
}
