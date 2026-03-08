namespace _06.ForeignLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();
            string output = string.Empty;

            switch (countryName)
            {
                case "USA":
                case "England": output = "English"; break;
                case "Spain":
                case "Argentina":
                case "Mexico": output = "Spanish"; break;
                default: output = "unknown"; break;
            }

            Console.WriteLine(output);
        }
    }
}
