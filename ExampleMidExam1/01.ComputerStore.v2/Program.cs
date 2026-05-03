using System.Text;

namespace _01.ComputerStore.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal totalPrice = 0;

            while (input != "special" && input != "regular")
            {
                decimal price = decimal.Parse(input);

                if (price >= 0)
                {
                    totalPrice += price;
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }

                input = Console.ReadLine();
            }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            decimal taxes = totalPrice * 0.2m;
            decimal priceWithTaxes = totalPrice + taxes;

            if (input == "special")
            {
                priceWithTaxes *= 0.9m;
            }

            StringBuilder builder = new();

            builder.AppendLine("Congratulations you've just bought a new computer!");
            builder.AppendLine($"Price without taxes: {totalPrice:F2}$");
            builder.AppendLine($"Taxes: {taxes:F2}$");
            builder.AppendLine("-----------");
            builder.AppendLine($"Total price: {priceWithTaxes:F2}$");

            Console.WriteLine(builder.ToString().TrimEnd());
        }
    }
}
