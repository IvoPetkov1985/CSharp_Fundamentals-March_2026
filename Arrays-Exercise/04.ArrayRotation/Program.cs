namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int rotationsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotationsCount % inputArray.Length; i++)
            {
                int temp = inputArray[0];

                for (int j = 0; j < inputArray.Length - 1; j++)
                {
                    inputArray[j] = inputArray[j + 1];
                }

                inputArray[^1] = temp;
            }

            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}
