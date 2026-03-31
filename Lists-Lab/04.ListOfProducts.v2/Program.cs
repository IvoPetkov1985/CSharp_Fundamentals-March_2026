namespace _04.ListOfProducts.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int productsCount = int.Parse(Console.ReadLine());
            string[] products = new string[productsCount];

            for (int i = 0; i < productsCount; i++)
            {
                string product = Console.ReadLine();
                products[i] = product;
            }

            Array.Sort(products);

            int counter = 0;

            foreach (string item in products)
            {
                counter++;
                Console.WriteLine($"{counter}.{item}");
            }
        }
    }
}
