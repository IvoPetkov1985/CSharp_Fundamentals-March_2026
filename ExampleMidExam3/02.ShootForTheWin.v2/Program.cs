namespace _02.ShootForTheWin.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "End")
            {
                int index = int.Parse(command);

                if (index < 0 || index >= targets.Length)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (targets[index] != -1)
                {
                    int shotValue = targets[index];
                    targets[index] = -1;

                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] == -1)
                        {
                            continue;
                        }

                        if (targets[i] > shotValue)
                        {
                            targets[i] -= shotValue;
                        }
                        else
                        {
                            targets[i] += shotValue;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            int targetsShot = targets.Where(x => x == -1).Count();
            Console.WriteLine($"Shot targets: {targetsShot} -> {string.Join(" ", targets)}");
        }
    }
}
