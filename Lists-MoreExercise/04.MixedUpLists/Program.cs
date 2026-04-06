namespace _04.MixedUpLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int minLength = Math.Min(firstArray.Length, secondArray.Length);
            List<int> resultList = new();
            Array.Reverse(secondArray);

            for (int i = 0; i < minLength; i++)
            {
                resultList.Add(firstArray[i]);
                resultList.Add(secondArray[i]);
            }

            int[] rangeNumbers = new int[2];

            if (firstArray.Length > secondArray.Length)
            {
                rangeNumbers = firstArray.TakeLast(2).ToArray();
            }
            else
            {
                rangeNumbers = secondArray.TakeLast(2).ToArray();
            }

            int minValue = rangeNumbers.Min();
            int maxValue = rangeNumbers.Max();
            resultList = resultList.FindAll(x => x > minValue && x < maxValue);
            resultList.Sort();
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
