namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int magicSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if ((inputArray[i] + inputArray[j]) == magicSum)
                    {
                        Console.WriteLine($"{inputArray[i]} {inputArray[j]}");
                    }
                }
            }
        }
    }
}
