namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());

            int[] train = new int[wagonsCount];

            for (int i = 0; i < wagonsCount; i++)
            {
                int passengers = int.Parse(Console.ReadLine());
                train[i] = passengers;
            }

            int totalPassengers = 0;

            for (int i = 0; i < train.Length - 1; i++)
            {
                totalPassengers += train[i];
                Console.Write(train[i] + " ");
            }

            totalPassengers += train[^1];
            Console.WriteLine(train[^1]);
            Console.WriteLine(totalPassengers);
        }
    }
}
