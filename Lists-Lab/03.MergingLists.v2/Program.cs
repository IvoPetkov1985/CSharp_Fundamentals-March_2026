namespace _03.MergingLists.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> resultList = new();

            int maxCount = Math.Max(firstList.Count, secondList.Count);

            for (int i = 0; i < maxCount; i++)
            {
                if (firstList.Count > i)
                {
                    resultList.Add(firstList[i]);
                }

                if (secondList.Count > i)
                {
                    resultList.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
