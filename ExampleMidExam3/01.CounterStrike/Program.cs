namespace _01.CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int wonBattlesCounter = 0;
            bool isTheGameWon = true;

            while (command != "End of battle")
            {
                int enemyDistance = int.Parse(command);

                if (enemyDistance <= energy)
                {
                    energy -= enemyDistance;
                    wonBattlesCounter++;

                    if (wonBattlesCounter % 3 == 0)
                    {
                        energy += wonBattlesCounter;
                    }
                }
                else
                {
                    isTheGameWon = false;
                    break;
                }

                command = Console.ReadLine();
            }

            if (isTheGameWon)
            {
                Console.WriteLine($"Won battles: {wonBattlesCounter}. Energy left: {energy}");
            }
            else
            {
                Console.WriteLine($"Not enough energy! Game ends with {wonBattlesCounter} won battles and {energy} energy");
            }
        }
    }
}
