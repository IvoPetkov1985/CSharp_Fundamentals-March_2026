namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int order = 0; order < ordersCount; order++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int daysCount = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                double orderPrice = daysCount * capsulesCount * capsulePrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
                totalPrice += orderPrice;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
