namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());

            Dictionary<string, string> parkingLot = new();

            for (int i = 0; i < commandsCount; i++)
            {
                string inputLine = Console.ReadLine();
                string[] arguments = inputLine.Split();
                string command = arguments[0];
                string username = arguments[1];

                if (command == "register")
                {
                    string licensePlateNumber = arguments[2];
                    bool isRegistered = parkingLot.TryAdd(username, licensePlateNumber);

                    if (isRegistered)
                    {
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingLot[username]}");
                    }
                }
                else if (command == "unregister")
                {
                    bool isRemoved = parkingLot.Remove(username);

                    if (isRemoved)
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (KeyValuePair<string, string> carInfo in parkingLot)
            {
                Console.WriteLine($"{carInfo.Key} => {carInfo.Value}");
            }
        }
    }
}
