namespace _01.CounterStrike.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int battlesWon = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End of battle")
                {
                    Console.WriteLine($"Won battles: {battlesWon}. Energy left: {energy}");
                    break;
                }

                int distance = int.Parse(command);

                if (energy >= distance)
                {
                    energy -= distance;
                    battlesWon++;

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
            }
        }
    }
}
