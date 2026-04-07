namespace _02.CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] trace = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            float leftCarTime = GetFirstCarTime(trace);
            float rightCarTime = GetSecondCarTime(trace);

            if (leftCarTime <= rightCarTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftCarTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightCarTime}");
            }
        }

        static float GetFirstCarTime(int[] trace)
        {
            float time = 0;

            for (int i = 0; i < trace.Length / 2; i++)
            {
                if (trace[i] != 0)
                {
                    time += trace[i];
                }
                else
                {
                    time *= 0.8f;
                }
            }

            return time;
        }

        static float GetSecondCarTime(int[] trace)
        {
            float time = 0;

            for (int i = trace.Length - 1; i > trace.Length / 2; i--)
            {
                if (trace[i] != 0)
                {
                    time += trace[i];
                }
                else
                {
                    time *= 0.8f;
                }
            }

            return time;
        }
    }
}
