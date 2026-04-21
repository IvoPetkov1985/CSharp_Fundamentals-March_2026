namespace _01.CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int battlesWon = 0;

            while (command != "End of battle")
            {
                int distance = int.Parse(command);

                if (energy >= distance)
                {
                    battlesWon++;
                    energy -= distance;

                    if (battlesWon % 3 == 0)
                    {
                        energy += battlesWon;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesWon} won battles and {energy} energy");
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "End of battle")
            {
                Console.WriteLine($"Won battles: {battlesWon}. Energy left: {energy}");
            }
        }
    }
}
