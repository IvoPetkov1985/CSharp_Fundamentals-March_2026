namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());

            for (int rotation = 0; rotation < rotations % numbers.Length; rotation++)
            {
                int firstNumber = numbers[0];

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    numbers[i] = numbers[i + 1];
                }

                numbers[numbers.Length - 1] = firstNumber;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
