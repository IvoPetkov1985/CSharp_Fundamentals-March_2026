namespace _03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            decimal sum = 0m;

            for (int i = 0; i < numbersCount; i++)
            {
                decimal inputNumber = decimal.Parse(Console.ReadLine());
                sum += inputNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
