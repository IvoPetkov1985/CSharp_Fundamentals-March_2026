namespace _10.RageExpenses.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double rageSum = 0;

            for (int game = 1; game <= gamesLost; game++)
            {
                if (game % 2 == 0)
                {
                    rageSum += headsetPrice;
                }

                if (game % 3 == 0)
                {
                    rageSum += mousePrice;
                }

                if (game % 6 == 0)
                {
                    rageSum += keyboardPrice;
                }

                if (game % 12 == 0)
                {
                    rageSum += displayPrice;
                }
            }

            Console.WriteLine($"Rage expenses: {rageSum:F2} lv.");
        }
    }
}
