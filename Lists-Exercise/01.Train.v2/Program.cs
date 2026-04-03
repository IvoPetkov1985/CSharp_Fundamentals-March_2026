namespace _01.Train.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] train = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] tokens = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                int value;

                switch (command)
                {
                    case "Add":
                        value = int.Parse(tokens[1]);
                        int[] wagons = new int[train.Length + 1];
                        Array.Copy(train, wagons, train.Length);
                        wagons[wagons.Length - 1] = value;
                        train = wagons;
                        break;
                    default:
                        value = int.Parse(tokens[0]);
                        int freeWagonIndex = Array.FindIndex(train, x => (capacity - x) >= value);

                        if (freeWagonIndex != -1)
                        {
                            train[freeWagonIndex] += value;
                        }

                        break;
                }
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}
