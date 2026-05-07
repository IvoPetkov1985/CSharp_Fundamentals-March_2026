namespace _02.ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int shotTargetsCounter = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                int index = int.Parse(input);

                if (index < 0 || index >= targets.Length || targets[index] == -1)
                {
                    continue;
                }

                shotTargetsCounter++;
                int targetValue = targets[index];
                targets[index] = -1;

                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] == -1)
                    {
                        continue;
                    }

                    if (targets[i] > targetValue)
                    {
                        targets[i] -= targetValue;
                    }
                    else
                    {
                        targets[i] += targetValue;
                    }
                }
            }

            Console.WriteLine($"Shot targets: {shotTargetsCounter} -> {string.Join(" ", targets)}");
        }
    }
}
