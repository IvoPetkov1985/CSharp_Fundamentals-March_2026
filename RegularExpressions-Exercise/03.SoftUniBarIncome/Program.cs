using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new(@"%(?<name>[A-Z][a-z]+)%[^\|\$\%\.]*?<(?<product>\w+)>[^\|\$\%\.]*?\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>\d+(\.\d+)?)\$");
            string inputLine = Console.ReadLine();
            decimal totalIncome = 0;

            while (inputLine != "end of shift")
            {
                Match match = pattern.Match(inputLine);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    decimal productPrice = price * count;
                    totalIncome += productPrice;

                    Console.WriteLine($"{name}: {product} - {productPrice:F2}");
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
