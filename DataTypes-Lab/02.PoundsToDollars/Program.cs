namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());

            decimal poundRate = 1.31m;
            decimal sumInDollars = pounds * poundRate;

            Console.WriteLine($"{sumInDollars:F3}");
        }
    }
}
