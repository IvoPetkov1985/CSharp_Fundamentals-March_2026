namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int counter = 1;
            int bestCounter = 0;
            int element = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    element = nums[i];
                }
            }

            for (int j = 1; j <= bestCounter; j++)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
