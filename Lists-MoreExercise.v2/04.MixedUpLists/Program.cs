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
            Array.Reverse(secondArray);

            int[] resultArray = new int[minLength * 2];
            int index = 0;

            for (int i = 0; i < resultArray.Length; i += 2)
            {
                resultArray[i] = firstArray[index];
                resultArray[i + 1] = secondArray[index];
                index++;
            }

            int[] rangeDetails = new int[2];

            if (firstArray.Length > secondArray.Length)
            {
                rangeDetails = firstArray.TakeLast(2).ToArray();
            }
            else
            {
                rangeDetails = secondArray.TakeLast(2).ToArray();
            }

            int minValue = rangeDetails.Min();
            int maxValue = rangeDetails.Max();

            Array.Sort(resultArray);
            int[] finalArray = Array.FindAll(resultArray, x => x > minValue && x < maxValue);
            Console.WriteLine(string.Join(" ", finalArray));
        }
    }
}
