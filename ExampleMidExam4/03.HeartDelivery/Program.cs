namespace _03.HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string inputLine = Console.ReadLine();
            int index = 0;

            while (inputLine != "Love!")
            {
                string[] arguments = inputLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int length = int.Parse(arguments[1]);
                index += length;

                if (index < 0 || index >= houses.Length)
                {
                    index = 0;
                }

                if (houses[index] == 0)
                {
                    Console.WriteLine($"Place {index} already had Valentine's day.");
                }
                else
                {
                    houses[index] -= 2;

                    if (houses[index] == 0)
                    {
                        Console.WriteLine($"Place {index} has Valentine's day.");
                    }
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {index}.");

            if (houses.All(h => h == 0))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int failedPlaces = houses.Where(h => h != 0).Count();
                Console.WriteLine($"Cupid has failed {failedPlaces} places.");
            }
        }
    }
}
