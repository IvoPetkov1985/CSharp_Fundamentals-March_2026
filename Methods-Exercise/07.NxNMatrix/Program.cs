namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumber; i++)
            {
                Console.WriteLine(CreateLine(inputNumber));
            }
        }

        static string CreateLine(int number)
        {
            int[] numbers = new int[number];
            
            for (int i = 0; i < number; i++)
            {
                numbers[i] = number;
            }

            return string.Join(" ", numbers);
        }
    }
}
