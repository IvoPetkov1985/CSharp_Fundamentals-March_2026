namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] ladybugsIndices = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[fieldSize];

            for (int i = 0; i < ladybugsIndices.Length; i++)
            {
                int ladybugIndex = ladybugsIndices[i];

                if (ladybugIndex >= 0 && ladybugIndex < fieldSize)
                {
                    field[ladybugIndex] = 1;
                }
            }

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int index = int.Parse(tokens[0]);
                string direction = tokens[1];
                int distance = int.Parse(tokens[2]);

                if (index >= 0 && index < fieldSize && field[index] == 1)
                {
                    field[index] = 0;

                    if (direction == "right")
                    {
                        do
                        {
                            index += distance;
                        }
                        while (index >= 0 && index < fieldSize && field[index] == 1);

                        if (index >= 0 && index < fieldSize)
                        {
                            field[index] = 1;
                        }
                    }
                    else if (direction == "left")
                    {
                        do
                        {
                            index -= distance;
                        }
                        while (index >= 0 && index < fieldSize && field[index] == 1);

                        if (index >= 0 && index < fieldSize)
                        {
                            field[index] = 1;
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
