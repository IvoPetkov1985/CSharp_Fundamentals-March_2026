namespace _01.BlackFlag.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double collectedPlunder = 0;

            for (int day = 1; day <= daysCount; day++)
            {
                collectedPlunder += dailyPlunder;

                if (day % 3 == 0)
                {
                    collectedPlunder += dailyPlunder * 0.5;
                }

                if (day % 5 == 0)
                {
                    collectedPlunder -= collectedPlunder * 0.3;
                }
            }

            if (collectedPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {collectedPlunder:F2} plunder gained.");
            }
            else
            {
                double percentage = collectedPlunder / expectedPlunder * 100;
                Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
            }
        }
    }
}
