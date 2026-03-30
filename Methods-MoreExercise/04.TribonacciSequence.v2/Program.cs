namespace _04.TribonacciSequence.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];

            if (count == 1)
            {
                numbers[0] = 1;
            }
            else if (count == 2)
            {
                numbers[0] = 1;
                numbers[1] = 1;
            }
            else if (count == 3)
            {
                numbers[0] = 1;
                numbers[1] = 1;
                numbers[2] = 2;
            }
            else
            {
                numbers[0] = 1;
                numbers[1] = 1;
                numbers[2] = 2;

                for (int i = 3; i < count; i++)
                {
                    numbers[i] = numbers[i - 3] + numbers[i - 2] + numbers[i - 1];
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
