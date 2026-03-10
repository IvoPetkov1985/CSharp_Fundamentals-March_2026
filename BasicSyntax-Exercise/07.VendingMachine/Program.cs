namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coin = Console.ReadLine();
            double balance = 0;

            while (coin != "Start")
            {
                double value = double.Parse(coin);

                if (value == 0.1 || value == 0.2 || value == 0.5 || value == 1 || value == 2)
                {
                    balance += value;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {value}");
                }

                coin = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                double price = 0;

                switch (product)
                {
                    case "Nuts": price = 2.00; break;
                    case "Water": price = 0.70; break;
                    case "Crisps": price = 1.50; break;
                    case "Soda": price = 0.80; break;
                    case "Coke": price = 1.00; break;
                    default: Console.WriteLine("Invalid product"); break;
                }

                if (price > balance)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    if (price > 0)
                    {
                        balance -= price;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                }

                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {balance:F2}");
        }
    }
}
