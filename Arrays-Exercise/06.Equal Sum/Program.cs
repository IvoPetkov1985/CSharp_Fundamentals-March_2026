namespace _06.Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isFound = false;
            int index = -1;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int leftSum = inputArray.Skip(0).Take(i).Sum();
                int rightSum = inputArray.Skip(i + 1).Take(inputArray.Length - i).Sum();

                if (leftSum == rightSum)
                {
                    index = i;
                    isFound = true;
                    break;
                }
            }

            if (isFound == false)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
