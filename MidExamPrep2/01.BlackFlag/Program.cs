namespace _01.BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int piratingDays = int.Parse(Console.ReadLine());
            int plunderPerDay = int.Parse(Console.ReadLine());
            double targetPlunder = double.Parse(Console.ReadLine());

            double totalPlunder = 0;

            for (int i = 1; i <= piratingDays; i++)
            {
                totalPlunder += plunderPerDay;

                if (i % 3 == 0)
                {
                    totalPlunder += plunderPerDay * 0.5;
                }

                if (i % 5 == 0)
                {
                    totalPlunder *= 0.7;
                }
            }

            if (totalPlunder >= targetPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:F2} plunder gained.");
            }
            else
            {
                double percentage = totalPlunder / targetPlunder * 100;
                Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
            }
        }
    }
}
