namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string commandLine = Console.ReadLine();

            while (commandLine != "end")
            {
                string[] argumrents = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = argumrents[0];

                if (command == "Add")
                {
                    int value = int.Parse(argumrents[1]);
                    train.Add(value);
                }
                else
                {
                    int passengersWaiting = int.Parse(argumrents[0]);
                    int wagon = train.Find(x => (maxCapacity - x) >= passengersWaiting);
                    int index = train.IndexOf(wagon);

                    if (index >= 0)
                    {
                        train[index] += passengersWaiting;
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}
