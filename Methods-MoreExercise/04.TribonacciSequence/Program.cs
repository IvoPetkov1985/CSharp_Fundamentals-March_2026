namespace _04.TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<int> numbers = new() { 1, 1, 2 };

            for (int i = 3; i < length; i++)
            {
                numbers.Add(numbers.TakeLast(3).Sum());
            }

            if (length <= 3)
            {
                Console.WriteLine(string.Join(" ", numbers.Take(length)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }                
        }
    }
}
