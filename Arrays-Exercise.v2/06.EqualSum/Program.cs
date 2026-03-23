namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int x1 = 0; x1 < i; x1++)
                {
                    leftSum += numbers[x1];
                }

                for (int x2 = i + 1; x2 < numbers.Length; x2++)
                {
                    rightSum += numbers[x2];
                }

                if (leftSum == rightSum)
                {
                    index = i;
                    break;
                }
            }

            if (index > -1)
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
