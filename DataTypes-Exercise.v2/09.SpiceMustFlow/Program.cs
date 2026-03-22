namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yieldPerDay = int.Parse(Console.ReadLine());

            int days = 0;
            int totalYield = 0;

            while (yieldPerDay >= 100)
            {
                totalYield += yieldPerDay;
                totalYield -= 26;
                days++;
                yieldPerDay -= 10;
            }

            totalYield -= 26;

            if (totalYield < 0)
            {
                totalYield = 0;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalYield);
        }
    }
}
