namespace _03.MovingTarget.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                string[] arguments = inputLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = arguments[0];
                int index = int.Parse(arguments[1]);

                switch (command)
                {
                    case "Shoot":

                        if (index >= 0 && index < targets.Count)
                        {
                            int power = int.Parse(arguments[2]);
                            targets[index] -= power;

                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                        }

                        break;
                    case "Add":

                        if (index >= 0 && index < targets.Count)
                        {
                            int value = int.Parse(arguments[2]);
                            targets.Insert(index, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }

                        break;
                    case "Strike":
                        int radius = int.Parse(arguments[2]);
                        int startIndex = index - radius;
                        int endIndex = index + radius;

                        if (startIndex >= 0 && startIndex < targets.Count &&
                            endIndex >= 0 && endIndex < targets.Count &&
                            endIndex >= startIndex)
                        {
                            targets.RemoveRange(startIndex, endIndex - startIndex + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }

                        break;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
