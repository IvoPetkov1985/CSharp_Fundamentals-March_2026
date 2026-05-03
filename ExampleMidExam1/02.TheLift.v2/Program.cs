namespace _02.TheLift.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            int[] lift = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int capacity = 4;
            int index = 0;

            while (peopleCount > 0)
            {
                int current = lift[index];
                int diff = capacity - current;

                if (peopleCount < diff)
                {
                    lift[index] += peopleCount;
                    peopleCount = 0;
                }
                else
                {
                    lift[index] += diff;
                    peopleCount -= diff;
                }

                index++;

                if (index == lift.Length)
                {
                    break;
                }
            }

            if (peopleCount == 0 && lift.All(x => x == capacity) == false)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            else if (peopleCount > 0 && lift.All(x => x == capacity) == true)
            {
                Console.WriteLine($"There isn't enough space! {peopleCount} people in a queue!");
            }

            Console.WriteLine(string.Join(" ", lift));
        }
    }
}
