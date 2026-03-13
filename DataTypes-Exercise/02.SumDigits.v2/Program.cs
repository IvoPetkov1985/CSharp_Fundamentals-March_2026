namespace _02.SumDigits.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int copyNumber = inputNumber;
            int sum = 0;

            while (copyNumber > 0)
            {
                sum += copyNumber % 10;
                copyNumber /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
