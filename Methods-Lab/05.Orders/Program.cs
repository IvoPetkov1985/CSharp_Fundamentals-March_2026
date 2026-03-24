namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Calculate(productName, quantity);
        }

        static void Calculate(string product, int quantity)
        {
            Dictionary<string, double> priceList = new()
            {
                { "coffee", 1.50 },
                { "water", 1.00 },
                { "coke", 1.40 },
                { "snacks", 2.00 }
            };

            double sum = priceList[product] * quantity;
            Console.WriteLine($"{sum:F2}");
        }
    }
}
