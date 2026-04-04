namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            List<string> arrays = inputLine
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            arrays.Reverse();

            List<int> resultList = new();

            foreach (string line in arrays)
            {
                int[] numbers = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                foreach (int number in numbers)
                {
                    resultList.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
