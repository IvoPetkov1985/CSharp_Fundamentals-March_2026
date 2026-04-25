namespace _04.MonthlyReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> clients = new();
            Dictionary<string, double> distributors = new();

            string commandLine = Console.ReadLine();

            while (commandLine != "End")
            {
                string[] tokens = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                string name = tokens[1];
                double value = double.Parse(tokens[2]);

                if (command == "Deliver")
                {
                    if (!distributors.ContainsKey(name))
                    {
                        distributors.Add(name, 0);
                    }

                    distributors[name] += value;
                }
                else if (command == "Return")
                {
                    if (distributors.ContainsKey(name))
                    {
                        if (value <= distributors[name])
                        {
                            distributors[name] -= value;

                            if (distributors[name] == 0)
                            {
                                distributors.Remove(name);
                            }
                        }
                    }
                }
                else if (command == "Sell")
                {
                    if (!clients.ContainsKey(name))
                    {
                        clients.Add(name, 0);
                    }

                    clients[name] += value;
                }

                commandLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, double> client in clients)
            {
                Console.WriteLine($"{client.Key}: {client.Value:F2}");
            }

            Console.WriteLine("-----------");

            foreach (KeyValuePair<string, double> distributor in distributors)
            {
                Console.WriteLine($"{distributor.Key}: {distributor.Value:F2}");
            }

            Console.WriteLine("-----------");

            double totalIncome = 0;

            if (clients.Count > 0)
            {
                totalIncome = clients.Values.Sum();
            }

            Console.WriteLine($"Total Income: {totalIncome:F2}");
        }
    }
}
