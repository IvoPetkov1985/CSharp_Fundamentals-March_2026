namespace _10.Pokemon.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint pokePower = uint.Parse(Console.ReadLine());
            uint targetDistance = uint.Parse(Console.ReadLine());
            byte exhaustionFactor = byte.Parse(Console.ReadLine());
            decimal halfPower = pokePower * 0.5m;

            uint pokesCount = 0;

            while (true)
            {
                if (pokePower < targetDistance)
                {
                    break;
                }

                pokePower -= targetDistance;
                pokesCount++;

                if (pokePower == halfPower && exhaustionFactor > 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokesCount);
        }
    }
}
