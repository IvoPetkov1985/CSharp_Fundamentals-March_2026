namespace _07.AppendArrays.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(arrays);
            string result = string.Empty;

            foreach (string arrayAsStr in arrays)
            {
                int[] currentArray = arrayAsStr
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                foreach (int number in currentArray)
                {
                    result += $"{number} ";
                }
            }

            result = result.TrimEnd();
            Console.WriteLine(result);
        }
    }
}
