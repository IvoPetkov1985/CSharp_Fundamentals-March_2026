namespace _10.Ladybugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] indices = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[fieldSize];

            for (int i = 0; i < indices.Length; i++)
            {
                int currentIndex = indices[i];

                if (currentIndex >= 0 && currentIndex < fieldSize)
                {
                    field[currentIndex] = 1;
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int index = int.Parse(tokens[0]);
                string direction = tokens[1];
                int distance = int.Parse(tokens[2]);

                if (index >= 0 && index < fieldSize && field[index] == 1)
                {
                    field[index] = 0;

                    switch (direction)
                    {
                        case "right":
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

                            break;

                        case "left":
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

                            break;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
