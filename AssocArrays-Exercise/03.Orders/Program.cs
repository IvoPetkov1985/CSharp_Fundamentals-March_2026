namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productInfo = Console.ReadLine();
            Dictionary<string, double[]> products = new();

            while (productInfo != "buy")
            {
                string[] productTokens = productInfo.Split();
                string name = productTokens[0];
                double singlePrice = double.Parse(productTokens[1]);
                double quantity = double.Parse(productTokens[2]);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, new double[] { singlePrice, quantity });
                }
                else
                {
                    products[name][0] = singlePrice;
                    products[name][1] += quantity;
                }

                productInfo = Console.ReadLine();
            }

            foreach (KeyValuePair<string, double[]> kvp in products)
            {
                double totalPrice = kvp.Value[0] * kvp.Value[1];
                Console.WriteLine($"{kvp.Key} -> {totalPrice:F2}");
            }
        }
    }
}
