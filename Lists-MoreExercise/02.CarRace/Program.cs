namespace _02.CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int middleIndex = numbers.Length / 2;
            float firstCarTime = 0;

            for (int i = 0; i < middleIndex; i++)
            {
                int time = numbers[i];

                if (time != 0)
                {
                    firstCarTime += time;
                }
                else
                {
                    firstCarTime *= 0.8f;
                }
            }

            float secondCarTime = 0;

            for (int i = numbers.Length - 1; i > middleIndex; i--)
            {
                int time = numbers[i];

                if (time != 0)
                {
                    secondCarTime += time;
                }
                else
                {
                    secondCarTime *= 0.8f;
                }
            }

            if (firstCarTime < secondCarTime)
            {
                Console.WriteLine($"The winner is left with total time: {firstCarTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {secondCarTime}");
            }
        }
    }
}
