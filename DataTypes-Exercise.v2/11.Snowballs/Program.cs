using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballsCount = int.Parse(Console.ReadLine());
            int bestBallSnow = 0;
            int bestBallTime = 0;
            int bestVallQuality = 0;
            BigInteger bestBallValue = 0;

            for (int i = 0; i < snowballsCount; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow(snow / time, quality);

                if (value > bestBallValue)
                {
                    bestBallSnow = snow;
                    bestBallTime = time;
                    bestVallQuality = quality;
                    bestBallValue = value;
                }
            }

            Console.WriteLine($"{bestBallSnow} : {bestBallTime} = {bestBallValue} ({bestVallQuality})");
        }
    }
}
