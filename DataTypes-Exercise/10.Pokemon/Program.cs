namespace _10.Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint pokePower = uint.Parse(Console.ReadLine());
            uint distance = uint.Parse(Console.ReadLine());
            uint exhaustionFactor = uint.Parse(Console.ReadLine());

            double halfPower = pokePower * 0.5d;
            uint counter = 0;
            
            while (pokePower >= distance)
            {
                pokePower -= distance;
                counter++;

                if (pokePower == halfPower && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(counter);
        }
    }
}
