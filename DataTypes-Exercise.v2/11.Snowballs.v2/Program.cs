using System.Numerics;

namespace _11.Snowballs.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numberOfSnowballs = byte.Parse(Console.ReadLine());

            short bestBallSnow = 0;
            short bestBallTime = 0;
            short bestBallQuality = 0;
            BigInteger bestBallValue = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                short snowballQuality = short.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > bestBallValue)
                {
                    bestBallSnow = snowballSnow;
                    bestBallTime = snowballTime;
                    bestBallQuality = snowballQuality;
                    bestBallValue = snowballValue;
                }
            }

            Console.WriteLine($"{bestBallSnow} : {bestBallTime} = {bestBallValue} ({bestBallQuality})");
        }
    }
}
