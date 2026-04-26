using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int barcodesCount = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"(@#+)(?<item>[A-Z][A-Za-z0-9]{4,}[A-Z])(@#+)");
            Regex digitRegex = new Regex(@"\d");

            for (int i = 0; i < barcodesCount; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string product = match.Groups["item"].Value;
                    string productGroup = "00";
                    MatchCollection digits = digitRegex.Matches(product);

                    if (digits.Count > 0)
                    {
                        productGroup = string.Join("", digits);
                    }

                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
