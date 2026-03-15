namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint dailyYield = uint.Parse(Console.ReadLine());

            uint days = 0;
            uint totalYield = 0;

            while (dailyYield >= 100)
            {
                totalYield += dailyYield;
                totalYield -= 26;
                days++;
                dailyYield -= 10;
            }

            if (totalYield >= 26)
            {
                totalYield -= 26;
            }
            else
            {
                totalYield = 0;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalYield);
        }
    }
}
