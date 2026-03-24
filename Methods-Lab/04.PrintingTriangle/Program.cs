namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintFirstHalf(number);
            PrintSecondHalf(number);
        }

        static void PrintSecondHalf(int number)
        {
            for (int i = number - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintFirstHalf(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintLine(1, i);
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
