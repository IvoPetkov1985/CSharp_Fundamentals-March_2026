namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] details = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bombNumber = details[0];
            int power = details[1];

            while (numbers.IndexOf(bombNumber) != -1)
            {
                int startIndex = numbers.IndexOf(bombNumber) - power;
                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                int endIndex = numbers.IndexOf(bombNumber) + power;
                if (endIndex >= numbers.Count)
                {
                    endIndex = numbers.Count - 1;
                }

                numbers.RemoveRange(startIndex, endIndex - startIndex + 1);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
