namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] train = new int[wagons];
            int total = 0;

            for (int i = 0; i < wagons; i++)
            {
                int passengers = int.Parse(Console.ReadLine());
                total += passengers;
                train[i] = passengers;
            }

            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(total);
        }
    }
}
