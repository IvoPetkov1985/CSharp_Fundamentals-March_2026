namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int[] ints = { firstNumber, secondNumber, thirdNumber };
            Console.WriteLine(string.Join(Environment.NewLine, ints.OrderByDescending(x => x)));
        }
    }
}
