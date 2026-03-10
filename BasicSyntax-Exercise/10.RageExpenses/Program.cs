namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsets = lostGames / 2;
            int mice = lostGames / 3;
            int keyboards = lostGames / 6;
            int displays = lostGames / 12;

            double sumHeadsets = headsets * headsetPrice;
            double sumMice = mice * mousePrice;
            double sumKeyboards = keyboards * keyboardPrice;
            double sumDisplays = displays * displayPrice;
            double rageSum = sumHeadsets + sumMice + sumKeyboards + sumDisplays;

            Console.WriteLine($"Rage expenses: {rageSum:F2} lv.");
        }
    }
}
