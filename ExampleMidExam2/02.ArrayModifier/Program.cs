namespace _02.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string commandLine = Console.ReadLine();

            while (commandLine != "end")
            {
                string[] arguments = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];

                if (command == "swap")
                {
                    int firstIndex = int.Parse(arguments[1]);
                    int secondIndex = int.Parse(arguments[2]);
                    int temp = values[firstIndex];
                    values[firstIndex] = values[secondIndex];
                    values[secondIndex] = temp;
                }
                else if (command == "multiply")
                {
                    int firstIndex = int.Parse(arguments[1]);
                    int secondIndex = int.Parse(arguments[2]);
                    values[firstIndex] *= values[secondIndex];
                }
                else if (command == "decrease")
                {
                    values = values.Select(x => x - 1).ToArray();
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", values));
        }
    }
}
