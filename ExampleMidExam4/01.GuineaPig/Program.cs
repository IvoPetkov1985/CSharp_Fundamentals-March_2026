namespace _01.GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foodInKg = double.Parse(Console.ReadLine());
            double hayInKg = double.Parse(Console.ReadLine());
            double coverInKg = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());

            double foodInG = foodInKg * 1000;
            double hayInG = hayInKg * 1000;
            double coverInG = coverInKg * 1000;
            double weightInG = weight * 1000;

            bool isFoodEnough = true;

            for (int day = 1; day <= 30; day++)
            {
                foodInG -= 300;

                if (day % 2 == 0)
                {
                    hayInG -= (foodInG * 0.05);
                }

                if (day % 3 == 0)
                {
                    coverInG -= (weightInG / 3);
                }

                if (foodInG <= 0 || hayInG <= 0 || coverInG <= 0)
                {
                    isFoodEnough = false;
                    Console.WriteLine("Merry must go to the pet store!");
                    break;
                }
            }

            if (isFoodEnough == true)
            {
                double excessFood = foodInG / 1000;
                double excessHay = hayInG / 1000;
                double excessCover = coverInG / 1000;
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {excessFood:F2}, Hay: {excessHay:F2}, Cover: {excessCover:F2}.");
            }
        }
    }
}
