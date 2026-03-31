namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] secondNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            List<int> resultList = new();

            int minLength = Math.Min(firstNumbers.Length, secondNumbers.Length);

            for (int i = 0; i < minLength; i++)
            {
                resultList.Add(firstNumbers[i]);
                resultList.Add(secondNumbers[i]);
            }

            if (firstNumbers.Length > secondNumbers.Length)
            {
                resultList.AddRange(firstNumbers.Skip(minLength));
            }
            else
            {
                resultList.AddRange(secondNumbers.Skip(minLength));
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
