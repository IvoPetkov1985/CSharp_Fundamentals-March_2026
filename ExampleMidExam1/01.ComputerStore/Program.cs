namespace _01.ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            decimal totalPrice = 0;
            bool isOrderValid = true;

            while (command != "special" && command != "regular")
            {
                decimal price = decimal.Parse(command);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    totalPrice += price;
                }

                command = Console.ReadLine();
            }

            if (totalPrice == 0)
            {
                isOrderValid = false;
            }

            decimal taxes = totalPrice * 0.2m;
            decimal finalPrice = totalPrice + taxes;

            if (command == "special")
            {
                finalPrice *= 0.9m;
            }

            if (isOrderValid == true)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {finalPrice:F2}$");
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
        }
    }
}
