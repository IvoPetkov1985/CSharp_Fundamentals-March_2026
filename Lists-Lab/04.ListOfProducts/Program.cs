namespace _04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int productsCount = int.Parse(Console.ReadLine());
            List<string> products = new();

            for (int i = 0; i < productsCount; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            products.Sort();

            for (int i = 0; i < productsCount; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
