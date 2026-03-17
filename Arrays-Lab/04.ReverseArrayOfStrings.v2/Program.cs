namespace _04.ReverseArrayOfStrings.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputArray.Length / 2; i++)
            {
                (inputArray[i], inputArray[inputArray.Length - 1 - i]) =
                    (inputArray[inputArray.Length - 1 - i], inputArray[i]);
            }

            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}
