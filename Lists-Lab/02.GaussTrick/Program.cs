namespace _02.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] inputArray = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            List<double> resultList = new();

            for (int i = 0; i < inputArray.Length / 2; i++)
            {
                double sum = inputArray[i] + inputArray[inputArray.Length - 1 - i];
                resultList.Add(sum);
            }

            if (inputArray.Length % 2 != 0)
            {
                resultList.Add(inputArray[inputArray.Length / 2]);
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
