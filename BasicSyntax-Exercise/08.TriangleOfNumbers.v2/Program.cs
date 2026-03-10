namespace _08.TriangleOfNumbers.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int row = 1; row <= number; row++)
            {
                string line = string.Empty;

                for (int col = 1; col <= row; col++)
                {
                    line += row + " ";
                }

                Console.WriteLine(line);
            }
        }
    }
}
