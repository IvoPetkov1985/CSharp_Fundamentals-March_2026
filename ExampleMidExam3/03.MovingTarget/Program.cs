namespace _03.MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string commandLine = Console.ReadLine();

            while (commandLine != "End")
            {
                string[] arguments = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];
                int index = int.Parse(arguments[1]);
                int value = int.Parse(arguments[2]);

                switch (command)
                {
                    case "Shoot":
                        if (IsIndexValid(index, targets))
                        {
                            targets[index] -= value;

                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                        }

                        break;

                    case "Add":
                        if (IsIndexValid(index, targets))
                        {
                            targets.Insert(index, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }

                        break;

                    case "Strike":
                        int startIndex = index - value;
                        int endIndex = index + value;

                        if (IsIndexValid(startIndex, targets) && IsIndexValid(endIndex, targets))
                        {
                            int length = endIndex - startIndex + 1;
                            targets.RemoveRange(startIndex, length);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }

                        break;
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targets));
        }

        static bool IsIndexValid(int index, List<int> targets)
        {
            return index >= 0 && index < targets.Count;
        }
    }
}
