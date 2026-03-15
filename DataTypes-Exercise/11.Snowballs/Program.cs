using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballsCount = int.Parse(Console.ReadLine());
            int highestSnow = 0;
            int highestTime = 0;
            int highestQuality = 0;
            BigInteger highestValue = 0;

            for (int ball = 0; ball < snowballsCount; ball++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue > highestValue)
                {
                    highestSnow = snowballSnow;
                    highestTime = snowballTime;
                    highestQuality = snowballQuality;
                    highestValue = snowballValue;
                }
            }

            Console.WriteLine($"{highestSnow} : {highestTime} = {highestValue} ({highestQuality})");
        }
    }
}
