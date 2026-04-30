namespace _03.BakeryShop.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> foods = new();
            List<int> sells = new();

            string inputLine = Console.ReadLine();

            while (inputLine != "Complete")
            {
                string[] arguments = inputLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];
                int quantity = int.Parse(arguments[1]);
                string food = arguments[2];

                switch (command)
                {
                    case "Receive":

                        if (quantity > 0)
                        {
                            foods.TryAdd(food, 0);
                            foods[food] += quantity;
                        }

                        break;
                    case "Sell":

                        if (foods.ContainsKey(food))
                        {
                            if (quantity <= foods[food])
                            {
                                foods[food] -= quantity;
                                sells.Add(quantity);
                                Console.WriteLine($"You sold {quantity} {food}.");

                                if (foods[food] == 0)
                                {
                                    foods.Remove(food);
                                }
                            }
                            else
                            {
                                sells.Add(foods[food]);
                                Console.WriteLine($"There aren't enough {food}. You sold the last {foods[food]} of them.");
                                foods.Remove(food);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"You do not have any {food}.");
                        }

                        break;
                }

                inputLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> foodInfo in foods)
            {
                Console.WriteLine($"{foodInfo.Key}: {foodInfo.Value}");
            }

            Console.WriteLine($"All sold: {sells.Sum()} goods");
        }
    }
}
