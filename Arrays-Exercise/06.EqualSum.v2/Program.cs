namespace _06.EqualSum.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int index = -1;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int x1 = 0; x1 < i; x1++)
                {
                    leftSum += inputArray[x1];
                }

                for (int x2 = i + 1; x2 < inputArray.Length; x2++)
                {
                    rightSum += inputArray[x2];
                }

                if (leftSum == rightSum)
                {
                    index = i;
                    break;
                }
            }

            if (index >= 0)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
