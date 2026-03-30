namespace _04.TribonacciSequence.v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int[] array = { 1, 1, 2 };

            for (int i = 4; i <= numbersCount; i++)
            {
                int[] currentArray = new int[i];

                for (int j = 0; j < currentArray.Length - 1; j++)
                {
                    currentArray[j] = array[j];                   
                }

                currentArray[currentArray.Length - 1] = array.TakeLast(3).Sum();
                array = currentArray;
            }

            Console.WriteLine(string.Join(" ", array.Take(numbersCount)));
        }
    }
}
