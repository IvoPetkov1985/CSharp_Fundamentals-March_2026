namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int[] firstArray = new int[inputNumber];
            int[] secondArray = new int[inputNumber];

            for (int i = 0; i < inputNumber; i++)
            {
                int[] inputArray = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    firstArray[i] = inputArray.First();
                    secondArray[i] = inputArray.Last();
                }
                else
                {
                    firstArray[i] = inputArray.Last();
                    secondArray[i] = inputArray.First();
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
