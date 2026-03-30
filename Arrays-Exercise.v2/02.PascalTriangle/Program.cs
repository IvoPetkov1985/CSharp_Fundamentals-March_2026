namespace _02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            long[] prevRow = Array.Empty<long>();

            for (int count = 1; count <= rowsCount; count++)
            {
                long[] row = new long[count];
                row[0] = 1;
                row[^1] = 1;

                for (int i = 1; i < row.Length - 1; i++)
                {
                    row[i] = prevRow[i - 1] + prevRow[i];
                }

                Console.WriteLine(string.Join(" ", row));

                prevRow = row;
            }
        }
    }
}
