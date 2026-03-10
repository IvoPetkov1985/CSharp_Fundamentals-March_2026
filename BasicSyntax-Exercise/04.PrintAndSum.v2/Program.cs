namespace _04.PrintAndSum.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            string output = string.Empty;
            
            for (int i = startNumber; i <= endNumber; i++)
            {
                sum += i;
                output += $"{i} ";
            }

            Console.WriteLine(output);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
