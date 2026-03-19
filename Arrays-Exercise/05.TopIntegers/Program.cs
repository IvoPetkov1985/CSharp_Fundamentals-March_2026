namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => long.Parse(x))
                .ToArray();

            List<long> topInts = new();

            for (int i = 0; i < inputArray.Length; i++)
            {
                bool isTop = true;

                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] <= inputArray[j])
                    {
                        isTop = false;
                    }
                }

                if (isTop == true)
                {
                    topInts.Add(inputArray[i]);
                }
            }

            Console.WriteLine(string.Join(" ", topInts));
        }
    }
}
