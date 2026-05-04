namespace _03.HeartDelivery.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int index = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Love!")
                {
                    break;
                }

                string[] tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int length = int.Parse(tokens[1]);

                index += length;

                if (index >= neighborhood.Length)
                {
                    index = 0;
                }

                if (neighborhood[index] > 0)
                {
                    neighborhood[index] -= 2;

                    if (neighborhood[index] == 0)
                    {
                        Console.WriteLine($"Place {index} has Valentine's day.");
                    }
                }
                else
                {
                    Console.WriteLine($"Place {index} already had Valentine's day.");
                }
            }

            Console.WriteLine($"Cupid's last position was {index}.");

            if (neighborhood.All(h => h == 0))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int failedHouses = neighborhood.Where(h => h != 0).Count();
                Console.WriteLine($"Cupid has failed {failedHouses} places.");
            }
        }
    }
}
