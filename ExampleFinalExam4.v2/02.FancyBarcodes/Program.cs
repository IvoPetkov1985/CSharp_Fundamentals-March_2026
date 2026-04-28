using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int barcodesCount = int.Parse(Console.ReadLine());
            Regex pattern = new(@"^(@#+)([A-Z][A-Za-z0-9]{4,}[A-Z])(@#+)$");
            Regex digitPattern = new(@"\d");

            for (int i = 0; i < barcodesCount; i++)
            {
                string barcode = Console.ReadLine();
                Match match = pattern.Match(barcode);

                if (match.Success)
                {
                    string product = match.Groups[2].Value;
                    string productGroup = "00";
                    MatchCollection digitCollection = digitPattern.Matches(product);

                    if (digitCollection.Count > 0)
                    {
                        productGroup = string.Join(string.Empty, digitCollection);
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
