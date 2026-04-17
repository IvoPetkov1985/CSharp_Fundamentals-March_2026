using System.Text;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Regex regex = new Regex(@">>(?<product>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)");
            List<string> boughtFurniture = new();
            decimal totalSum = 0;

            while (inputLine != "Purchase")
            {
                Match match = regex.Match(inputLine);

                if (match.Success)
                {
                    string productName = match.Groups["product"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    boughtFurniture.Add(productName);
                    totalSum += price * quantity;
                }

                inputLine = Console.ReadLine();
            }

            StringBuilder builder = new();

            builder.AppendLine("Bought furniture:");

            foreach (string furniture in boughtFurniture)
            {
                builder.AppendLine(furniture);
            }

            builder.AppendLine($"Total money spend: {totalSum:F2}");
            Console.WriteLine(builder.ToString().TrimEnd());
        }
    }
}
