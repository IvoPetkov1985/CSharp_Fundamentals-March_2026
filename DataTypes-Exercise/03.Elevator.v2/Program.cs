namespace _03.Elevator.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int result = peopleWaiting / capacity;

            if (peopleWaiting % capacity != 0)
            {
                result++;
            }

            Console.WriteLine(result);
        }
    }
}
