namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte count = sbyte.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += letter;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
