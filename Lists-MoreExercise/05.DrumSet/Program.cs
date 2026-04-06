namespace _05.DrumSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal savings = decimal.Parse(Console.ReadLine());
            List<int> drumQualities = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> currentQualities = new(drumQualities);
            string command = Console.ReadLine();

            while (command != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);

                for (int i = 0; i < currentQualities.Count; i++)
                {
                    currentQualities[i] -= hitPower;

                    if (currentQualities[i] <= 0)
                    {
                        decimal drumPrice = drumQualities[i] * 3;

                        if (drumPrice <= savings)
                        {
                            currentQualities[i] = drumQualities[i];
                            savings -= drumPrice;
                        }
                        else
                        {
                            currentQualities.RemoveAt(i);
                            drumQualities.RemoveAt(i);
                            i--;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", currentQualities));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
