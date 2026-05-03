namespace _02.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int cabinCapacity = 4;

            for (int i = 0; i < lift.Length; i++)
            {
                int currentCapacity = cabinCapacity - lift[i];

                if (peopleWaiting <= currentCapacity)
                {
                    lift[i] += peopleWaiting;
                    peopleWaiting = 0;
                    break;
                }
                else
                {
                    lift[i] += currentCapacity;
                    peopleWaiting -= currentCapacity;
                }
            }

            if (peopleWaiting == 0 && !lift.All(x => x == 4))
            {
                Console.WriteLine("The lift has empty spots!");
            }
            else if (peopleWaiting > 0 && lift.All(x => x == 4))
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            }

            Console.WriteLine(string.Join(" ", lift));
        }
    }
}
