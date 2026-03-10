namespace _07.VendingMachine.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;

            while (true)
            {
                string coin = Console.ReadLine();

                if (coin == "Start")
                {
                    break;
                }

                double coinValue = double.Parse(coin);

                if (coinValue == 0.1 || coinValue == 0.2 || coinValue == 0.5 || coinValue == 1 || coinValue == 2)
                {
                    balance += coinValue;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coinValue}");
                }
            }

            while (true)
            {
                string product = Console.ReadLine();

                if (product == "End")
                {
                    break;
                }

                double productPrice = 0;

                if (product == "Nuts")
                {
                    productPrice = 2;
                }
                else if (product == "Water")
                {
                    productPrice = 0.7;
                }
                else if (product == "Crisps")
                {
                    productPrice = 1.5;
                }
                else if (product == "Soda")
                {
                    productPrice = 0.8;
                }
                else if (product == "Coke")
                {
                    productPrice = 1;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                if (productPrice > balance)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    balance -= productPrice;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
            }

            Console.WriteLine($"Change: {balance:F2}");
        }
    }
}
