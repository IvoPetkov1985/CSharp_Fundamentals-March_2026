namespace _01.GuineaPig.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal foodInKg = decimal.Parse(Console.ReadLine());
            decimal hayInKg = decimal.Parse(Console.ReadLine());
            decimal coverInKg = decimal.Parse(Console.ReadLine());
            decimal weightInKg = decimal.Parse(Console.ReadLine());
            bool isEverythingFine = true;

            for (int day = 1; day <= 30; day++)
            {
                foodInKg -= 0.3m;

                if (day % 2 == 0)
                {
                    decimal currentHay = foodInKg * 0.05m;
                    hayInKg -= currentHay;
                }

                if (day % 3 == 0)
                {
                    decimal currentCover = weightInKg / 3;
                    coverInKg -= currentCover;
                }

                if (foodInKg <= 0 || hayInKg <= 0 || coverInKg <= 0)
                {
                    isEverythingFine = false;
                    break;
                }
            }

            if (isEverythingFine == true)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodInKg:F2}, Hay: {hayInKg:F2}, Cover: {coverInKg:F2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
        }
    }
}
