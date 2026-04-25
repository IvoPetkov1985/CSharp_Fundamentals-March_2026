namespace _01.GoogleSearches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal moneyPerSearch = decimal.Parse(Console.ReadLine());
            int usersCount = int.Parse(Console.ReadLine());
            decimal totalMoney = 0;

            for (int user = 1; user <= usersCount; user++)
            {
                int searches = int.Parse(Console.ReadLine());

                if (searches <= 1)
                {
                    continue;
                }

                decimal currentMoney = searches * moneyPerSearch;

                if (searches > 5)
                {
                    currentMoney *= 2;
                }

                if (user % 3 == 0)
                {
                    currentMoney *= 3;
                }

                totalMoney += currentMoney;
            }

            Console.WriteLine($"Total money earned: {totalMoney:F2}");
        }
    }
}
