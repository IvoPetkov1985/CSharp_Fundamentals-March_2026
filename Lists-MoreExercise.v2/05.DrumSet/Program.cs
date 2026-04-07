namespace _05.DrumSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());

            List<int> initialQualities = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> currentQualities = new(initialQualities);

            string command = Console.ReadLine();

            while (command != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);
                currentQualities = currentQualities
                    .Select(x => x -= hitPower).ToList();

                for (int i = 0; i < currentQualities.Count; i++)
                {
                    int drumQuality = currentQualities[i];

                    if (drumQuality <= 0)
                    {
                        decimal drumPrice = initialQualities[i] * 3;

                        if (drumPrice <= budget)
                        {
                            budget -= drumPrice;
                            currentQualities[i] = initialQualities[i];
                        }
                        else
                        {
                            currentQualities.RemoveAt(i);
                            initialQualities.RemoveAt(i);
                            i--;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", currentQualities));
            Console.WriteLine($"Gabsy has {budget:F2}lv.");
        }
    }
}
