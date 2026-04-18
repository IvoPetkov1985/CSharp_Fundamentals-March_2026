namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> quantitiesMap = new();
            Dictionary<string, decimal> pricesMap = new();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "buy")
                {
                    break;
                }

                string[] arguments = inputLine.Split();
                string product = arguments[0];
                decimal price = decimal.Parse(arguments[1]);
                int quantity = int.Parse(arguments[2]);

                if (!quantitiesMap.ContainsKey(product))
                {
                    quantitiesMap.Add(product, quantity);
                    pricesMap.Add(product, price);
                }
                else
                {
                    quantitiesMap[product] += quantity;
                    pricesMap[product] = price;
                }
            }

            foreach (KeyValuePair<string, int> productInfo in quantitiesMap)
            {
                decimal totalPrice = productInfo.Value * pricesMap[productInfo.Key];
                Console.WriteLine($"{productInfo.Key} -> {totalPrice:F2}");
            }
        }
    }
}
