namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string result = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTop = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] >= numbers[i])
                    {
                        isTop = false;
                        break;
                    }
                }

                if (isTop == true)
                {
                    result += $"{numbers[i]} ";
                }
            }

            Console.WriteLine(result.TrimEnd());
        }
    }
}
