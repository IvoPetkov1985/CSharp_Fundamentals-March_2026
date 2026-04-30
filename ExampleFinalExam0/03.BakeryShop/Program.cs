namespace _03.BakeryShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> foodsQuantities = new();
            int soldFoods = 0;

            string commandLine = Console.ReadLine();

            while (commandLine != "Complete")
            {
                string[] tokens = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                int quantity = int.Parse(tokens[1]);
                string food = tokens[2];

                if (command == "Receive")
                {
                    if (quantity > 0)
                    {
                        if (foodsQuantities.ContainsKey(food) == false)
                        {
                            foodsQuantities.Add(food, 0);
                        }

                        foodsQuantities[food] += quantity;
                    }
                }
                else if (command == "Sell")
                {
                    if (foodsQuantities.ContainsKey(food) == false)
                    {
                        Console.WriteLine($"You do not have any {food}.");
                    }
                    else
                    {
                        if (foodsQuantities[food] >= quantity)
                        {
                            foodsQuantities[food] -= quantity;
                            soldFoods += quantity;
                            Console.WriteLine($"You sold {quantity} {food}.");

                            if (foodsQuantities[food] == 0)
                            {
                                foodsQuantities.Remove(food);
                            }
                        }
                        else
                        {
                            soldFoods += foodsQuantities[food];
                            Console.WriteLine($"There aren't enough {food}. You sold the last {foodsQuantities[food]} of them.");
                            foodsQuantities[food] = 0;
                            foodsQuantities.Remove(food);
                        }
                    }
                }

                commandLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> food in foodsQuantities)
            {
                Console.WriteLine($"{food.Key}: {food.Value}");
            }

            Console.WriteLine($"All sold: {soldFoods} goods");
        }
    }
}
