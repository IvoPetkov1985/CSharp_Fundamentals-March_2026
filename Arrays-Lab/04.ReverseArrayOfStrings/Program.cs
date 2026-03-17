namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arrayOfStrings.Length / 2; i++)
            {
                string temp = arrayOfStrings[i];
                arrayOfStrings[i] = arrayOfStrings[arrayOfStrings.Length - 1 - i];
                arrayOfStrings[arrayOfStrings.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", arrayOfStrings));
        }
    }
}
