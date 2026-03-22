namespace _09.SpiceMustFlow.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint yieldPerDay = uint.Parse(Console.ReadLine());
            uint totalYield = 0;
            uint days = 0;

            while (true)
            {
                if (yieldPerDay < 100)
                {
                    break;
                }

                days++;
                totalYield += yieldPerDay;
                totalYield -= 26;
                yieldPerDay -= 10;
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
