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

            int targetsShot = 0;
            string input = Console.ReadLine();

            while (input != "End")
            {
                int index = int.Parse(input);

                if (index < 0 || index >= targets.Length)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (targets[index] != -1)
                {
                    targetsShot++;
                    int value = targets[index];
                    targets[index] = -1;

                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] == -1)
                        {
                            continue;
                        }

                        if (targets[i] > value)
                        {
                            targets[i] -= value;
                        }
                        else
                        {
                            targets[i] += value;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {targetsShot} -> {string.Join(" ", targets)}");
        }
    }
}
